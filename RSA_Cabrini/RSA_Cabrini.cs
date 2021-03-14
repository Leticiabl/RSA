using System;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Diagnostics;
using System.Numerics;
using System.Security.Cryptography;
using Base58Check;



namespace RSA_Cabrini
{
    public partial class RSA_Cabrini : Form
    {

        BigInteger primo1, primo2, n, phi, publicExp, privateExp;
        RandomNumberGenerator rng = RandomNumberGenerator.Create();
        UInt16 primo1Cnt, primo2Cnt;
        Thread thread1, thread2;
        Boolean primo1Status, primo2Status;

        public RSA_Cabrini()
        {
            InitializeComponent();
        }

        private void mainForm_Load(object sender, EventArgs e)
        {

            txtPrimo1_TextChanged(null, EventArgs.Empty);
            txtPrimo2_TextChanged(null, EventArgs.Empty);
            txtMensagem_TextChanged(null, EventArgs.Empty);
        }

        private void btnGeraPrimos_Click(object sender, EventArgs e)
        {
            btnGeraPrimos.Enabled = false;
            btnCalcula.Enabled = false;
            txtPrimo1.Clear();
            txtPrimo2.Clear();

            progressTimer.Start();
            int bitsize = 2048;

            primo1 = new BigInteger(0);
            primo1Cnt = 0;
            primo1Status = false;
            thread1 = new Thread(() => GenPrimo(ref primo1, bitsize, ref primo1Cnt));
            thread1.IsBackground = true;
            thread1.Start();

            primo2 = new BigInteger(0);
            primo2Cnt = 0;
            primo2Status = false;
            thread2 = new Thread(() => GenPrimo(ref primo2, bitsize, ref primo2Cnt));
            thread2.IsBackground = true;
            thread2.Start();

            if (primo1 == 0)
            {
            }
            else if (!primo1Status)
            {
                txtPrimo1.Text += primo1.ToString();
                primo1Status = true;
            }

            if (primo2 == 0)
            {
            }
            else if (!primo2Status)
            {
                txtPrimo2.Text += primo2.ToString();
                primo2Status = true;
            }

            if (primo1 != 0 && primo2 != 0)
            {
                btnGeraPrimos.Enabled = true;
                btnCalcula.Enabled = true;
                progressTimer.Stop();
            }
        }

        private void progressTimer_Tick(object sender, EventArgs e)
        {
            if (primo1 == 0)
            {
            }
            else if (!primo1Status)
            {
                txtPrimo1.Text += primo1.ToString();
                primo1Status = true;
            }

            if (primo2 == 0)
            {
            }
            else if (!primo2Status)
            {
                txtPrimo2.Text += primo2.ToString();
                primo2Status = true;
            }

            if (primo1 != 0 && primo2 != 0)
            {
                btnGeraPrimos.Enabled = true;
                btnCalcula.Enabled = true;
                progressTimer.Stop();
            }
        }

        private void GenPrimo(ref BigInteger primo, int bitsize, ref UInt16 count)
        {
            RandomNumberGenerator rbg = RandomNumberGenerator.Create();
            int wlen = (bitsize / 8) + 1;

            byte[] bytes = new byte[wlen];
            BigInteger testPrimo;
            rbg.GetBytes(bytes);
            bytes[wlen - 1] = 0x00;
            bytes[0] |= (Byte)0x01;
            testPrimo = new BigInteger(bytes);
            

            bool IsProbablePrime = false;
            while (!IsProbablePrime && count <= 2e3)
            {
                IsProbablePrime = false;
                count++;
                testPrimo += 2;
                IsProbablePrime = testPrimo.IsProbablePrime(5);
            }
            
            if (IsProbablePrime)
            {
                bytes = testPrimo.ToByteArray();
                primo = testPrimo;
            }
            else
            {
                primo = BigInteger.Zero;
            }
        }

        private void btnCalcula_Click(object sender, EventArgs e)
        {
            limparChave ();
            CalculaChave();

        }

        private void limparChave()
        {
            txtN.Text = "";
            nLen.Text = "Bitsize: --";
            txtPhi.Text = "";
            dBox.Text = "";
            txtE.Text = "";

            btnCrypt.Enabled = false;
            btnDecrypt.Enabled = false;
            txtDecriptado.Text = "";
            txtEncriptado.Text = "";
            this.Refresh();
        }

        private bool CalculaChave()
        {
            try
            {
                primo1 = BigInteger.Parse(txtPrimo1.Text);
                primo2 = BigInteger.Parse(txtPrimo2.Text);
                publicExp = 7499;
            }
            catch
            {
                MessageBox.Show("Gere os números primos novamente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }


            if (primo1 == primo2)
                return false;

            if (primo2 > primo1)
            {
                txtPrimo1.Text = primo2.ToString();
                txtPrimo2.Text = primo1.ToString();
                primo1 = BigInteger.Parse(txtPrimo1.Text);
                primo2 = BigInteger.Parse(txtPrimo2.Text);
            }


            UInt16 prime1BitSize = primo1.GetBitsize();
            UInt16 prime2BitSize = primo2.GetBitsize();
            if (prime1BitSize < 2048 || prime2BitSize < 2048)
            {
                MessageBox.Show("Gere os números primos novamente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            n = BigInteger.Multiply(primo1, primo2);
            txtN.Text = n.ToString();
            nLen.Text = "Bitsize: " + n.GetBitsize();

            phi = BigInteger.Multiply(primo1 - 1, primo2 - 1);
            txtPhi.Text = phi.ToString();
            BigInteger divisorComum = BigInteger.GreatestCommonDivisor(publicExp, phi);
            if (divisorComum != 1)
            {
                MessageBox.Show("Divisor Comum != 1", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            txtE.Text = publicExp.ToString();
            privateExp = publicExp.modInverse(ref phi);
            dBox.Text = privateExp.ToString();
            BigInteger testD = BigInteger.Multiply(publicExp, privateExp) % phi;
            txt1.Text = testD.ToString();

            btnCrypt.Enabled = true;
            btnDecrypt.Enabled = true;
            return true;
        }
        
        private void btnCrypt_Click(object sender, EventArgs e)
        {
            txtEncriptado.Text = "";
            this.Refresh();

            int blocklen = (n.GetBitsize() / 8) - 4;
            if (blocklen < 5)
            {
                MessageBox.Show("Chave Pequena", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            byte[] plaintextArr = Encoding.UTF8.GetBytes(txtMensagem.Text);
            UInt16 blockCnt = 0;
            String finalString = "";
            foreach (byte[] plainBlock in plaintextArr.Slices(blocklen))
            {

                byte[] withPadArr = new byte[plainBlock.Length + 4];
                byte[] padArr = new byte[4];
                rng.GetBytes(padArr);
                padArr[0] &= (Byte)0x7F;
                Array.Copy(padArr, withPadArr, 4);
                Array.Copy(plainBlock, 0, withPadArr, 4, plainBlock.Length);
                Array.Reverse(withPadArr);
                BigInteger toCrypt = new BigInteger(withPadArr);
                BigInteger crypt = BigInteger.ModPow(toCrypt, publicExp, n);
                byte[] cryptArr = crypt.ToByteArray();
                String b58Enc = Base58CheckEncoding.Encode(cryptArr).ToString();
                finalString += b58Enc + "_";

                blockCnt++;
            }

            txtEncriptado.Text = finalString.TrimEnd('_');
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();
            txtDecriptado.Text = "";
            this.Refresh();
            String startString = txtEncriptado.Text;
            UInt16 blockCnt = 0;
            String finalString = "";
            foreach (string cryptBlock in startString.Split('_'))
            {
                byte[] cryptArr;
                try
                {
                    cryptArr = Base58CheckEncoding.Decode(cryptBlock);
                }
                catch
                {
                    return;
                }

                BigInteger criptado = new BigInteger(cryptArr);
                BigInteger decriptado = BigInteger.ModPow(criptado, privateExp, n);
                byte[] decryptWithPadArr = decriptado.ToByteArray();
                byte[] decryptArr = new byte[decryptWithPadArr.Length - 4];
                Array.Copy(decryptWithPadArr, decryptArr, decryptArr.Length);
                Array.Reverse(decryptArr);
                String rsaDec = Encoding.UTF8.GetString(decryptArr);
                finalString += rsaDec;
                blockCnt++;
            }

            txtDecriptado.Text = finalString;
            watch.Stop();
            var elapsedMs = watch.ElapsedMilliseconds;
        }

        private void txtMensagem_TextChanged(object sender, EventArgs e)
        {
            plainLen.Text = "Lenght: " + txtMensagem.Text.Length.ToString();
        }

        private void txtPrimo1_TextChanged(object sender, EventArgs e)
        {
            p1Len.Text = "Lenght: " + txtPrimo1.Text.Length.ToString();
            limparChave();
        }

        private void txtPrimo2_TextChanged(object sender, EventArgs e)
        {
            p2Len.Text = "Lenght: " + txtPrimo2.Text.Length.ToString();
            limparChave();
        }
    }
}

