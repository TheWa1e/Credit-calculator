using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            priceInitialType.SelectedIndex = 0;
            pricePeriodCombo.SelectedIndex = 0;
            priceAnnuitet.Checked = true;
        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
            priceCreditSum1.Focus();
        }

        private void priceInitial_Enter(object sender, EventArgs e)
        {
            priceInitial.Select(0, priceInitial.Text.Length);
        }

        private void priceProcent_Enter(object sender, EventArgs e)
        {
            priceProcent.Select(0, priceProcent.Text.Length);
        }

        private void pricePeriod_Enter(object sender, EventArgs e)
        {
            pricePeriod.Select(0, pricePeriod.Text.Length);
        }

       
        private void CreditSumFunc() // Метод подсчета суммы кредита
        {
            double ValueOfPurchase = Convert.ToDouble(priceCreditSum1.Value);
            double InitialPayment = Convert.ToDouble(priceInitial.Value);
            if (priceInitialType.SelectedIndex == 0)
            {
                priceCreditSum.Text = (ValueOfPurchase - InitialPayment).ToString("N2");
            }
            else
            {
                priceCreditSum.Text = (ValueOfPurchase - ((ValueOfPurchase * InitialPayment) / 100)).ToString("N2");
            }
        }

            
        private void PaymentScheduleAnnuitet(double SumCredit, double InterestRateYear, double InterestRateMonth, int CreditPeriod) // Метод расчета Аннуитетного платежа
        {
            double Payment = SumCredit * (InterestRateMonth / (1 - Math.Pow(1 + InterestRateMonth, -CreditPeriod))); // Ежемесячный платеж
            double ItogCreditSum = Payment * CreditPeriod; // Итоговая сумма кредита
            itogPayment.Text = Payment.ToString("N2"); // Выводим в результаты ежемесячный платёж
            itogSum.Text = (ItogCreditSum).ToString("N2"); // Выводим в результаты итоговую сумму кредита
                                                           // Заполняем график платежей
            double SumCreditOperation = SumCredit;
            double ItogCreditSumOperation = ItogCreditSum;
            double ItogPlus = 0;
            for (int i = 0; i < CreditPeriod; ++i)
            {
                double procent = SumCreditOperation * (InterestRateYear / 100) / 12;
                SumCreditOperation -= Payment - procent;
                dgvGrafik.Rows.Add();
                dgvGrafik[0, i].Value = i + 1; //номер месяца
                dgvGrafik[1, i].Value = Payment.ToString("N2"); //Ежемесячный платеж
                dgvGrafik[2, i].Value = (Payment - procent).ToString("N2"); //Платеж за основной долг
                dgvGrafik[3, i].Value = procent.ToString("N2"); //Платеж процента
                dgvGrafik[4, i].Value = SumCreditOperation.ToString("N2"); //Основной остаток
                ItogCreditSumOperation -= Payment;
                ItogPlus = Convert.ToDouble(dgvGrafik[4, i].Value);
            }
            itogOverpayment.Text = (ItogCreditSum - SumCredit + ItogPlus).ToString("N2");
        }

        private void PaymentScheduleDiffer(double SumCredit, double InterestRateMonth, int CreditPeriod) // Метод расчета Дифференцированного платежа
        {
            double MainPayment = SumCredit / CreditPeriod; // платеж по основному долгу
                                                           // Заполняем график платежей
            double ItogCreditSum = 0;
            double OverPaymentSum = 0;
            for (int i = 0; i < CreditPeriod; ++i)
            {
                double procentPart = SumCredit * InterestRateMonth; //подсчет процентной части ежемесячного платежа
                SumCredit -= MainPayment; //подсчет остатка основного долга (с каждым месяцем уменьшается)
                dgvGrafik.Rows.Add(); //добавляем строку в таблицу
                dgvGrafik[0, i].Value = i + 1; //номер месяца
                dgvGrafik[1, i].Value = (MainPayment + procentPart).ToString("N2"); //полный ежемесячный платеж
                dgvGrafik[2, i].Value = MainPayment.ToString("N2"); //платеж по основному долгу
                dgvGrafik[3, i].Value = procentPart.ToString("N2"); //процентная часть ежемесячного платежа
                dgvGrafik[4, i].Value = SumCredit.ToString("N2"); //Остаток по основному долгу
            }
            for (int i = 0; i < CreditPeriod; ++i) //Подсчет итоговой стоимости и переплаты по кредиту
            {
                ItogCreditSum += Convert.ToDouble(dgvGrafik[1, i].Value);
                OverPaymentSum += Convert.ToDouble(dgvGrafik[3, i].Value);
            }
            double ItogPlus = Convert.ToDouble(dgvGrafik[4, dgvGrafik.RowCount - 1].Value);
            itogSum.Text = ItogCreditSum.ToString("N2");
            itogOverpayment.Text = (OverPaymentSum + ItogPlus).ToString("N2");
            itogPayment.Text = Convert.ToString(dgvGrafik[1, 0].Value) + "..." + Convert.ToString(dgvGrafik[1, dgvGrafik.RowCount - 1].Value);
        }

        private void butPriceGo_Click(object sender, EventArgs e)
        {
            if ((Convert.ToInt32(priceInitial.Value) > Convert.ToInt32(priceCreditSum1.Value)) || (priceInitialType.SelectedIndex == 1 && Convert.ToInt32(priceInitial.Value) > 99))
            {
                MessageBox.Show("Сумма кредита не может быть отрицательной или равной нулю.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                dgvGrafik.Rows.Clear(); // Очищаем таблицу
                double SumCredit = Convert.ToDouble(priceCreditSum1.Value); // Сумма кредита
                double InterestRateYear = Convert.ToDouble(priceProcent.Value); // Процентная ставка, ГОДОВАЯ
                double InterestRateMonth = InterestRateYear / 100 / 12; // Процентная ставка, МЕСЯЧНАЯ
                int CreditPeriod = Convert.ToInt32(pricePeriod.Value); // Срок кредита, переводим в месяцы, если указан в годах
                if (pricePeriodCombo.SelectedIndex == 0)
                    CreditPeriod *= 12;
                if (priceAnnuitet.Checked == true) // Аннуитетный платеж
                {
                    PaymentScheduleAnnuitet(SumCredit, InterestRateYear, InterestRateMonth, CreditPeriod);
                }
                else if (priceDiffer.Checked == true) // Дифференцированный платеж
                {
                    PaymentScheduleDiffer(SumCredit, InterestRateMonth, CreditPeriod);
                }
            }
        }

        private void butPriceClear_Click(object sender, EventArgs e)
        {
            priceCreditSum1.Value = priceCreditSum1.Minimum;
            priceInitial.Value = priceInitial.Minimum;
            priceInitialType.SelectedIndex = 0;
            priceProcent.Value = priceProcent.Minimum;
            pricePeriod.Value = pricePeriod.Minimum;
            pricePeriodCombo.SelectedIndex = 0;
            itogSum.Clear();
            itogOverpayment.Clear();
            itogPayment.Clear();
            dgvGrafik.Rows.Clear();
        }
    }
}

