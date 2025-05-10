using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PasteCalculation
{
    /// <summary>
    /// 貼り付け計算機
    /// </summary>
    public partial class PasteCalculation : Form
    {
        /// <summary>
        /// 計算種別
        /// </summary>
        public enum CalculationType
        {
            /// <summary>
            /// プラスマイナス計算
            /// </summary>
            MC = 0,

            /// <summary>
            /// 掛け算
            /// </summary>
            M = 1,

            /// <summary>
            /// 割り算
            /// </summary>
            D = 2
        }

        /// <summary>
        /// 表示数値フォーマット #,##0
        /// </summary>
        const string COMMA_NUMBER_VIEW_FORMAT = "#,##0";

        /// <summary>
        /// 数値フォーマット #,##0
        /// </summary>
        const string COMMA_NUMBER_FORMAT = "{0:#,0.#############}";

        /// <summary>
        /// 表示数値フォーマット ###0
        /// </summary>
        const string NUMBER_VIEW_FORMAT = "###0";

        /// <summary>
        /// 改行
        /// </summary>
        const string NEW_LINE = "\n";

        /// <summary>
        /// コンストラクタ処理
        /// </summary>
        public PasteCalculation()
        {
            InitializeComponent();

            PMCheckBox.Checked = true;
            MCheckBox.Checked = true;
            DCheckBox.Checked = true;
        }

        /// <summary>
        /// クリアボタン押下処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClearButton_Click(object sender, EventArgs e)
        {
            CalculationTextBox.Text = string.Empty;
            PlusOrMinusTextBox.Text = string.Empty;
            MultiplicationTextBox.Text = string.Empty;
            DivisionTextBox.Text = string.Empty;

            PMCheckBox.Checked = true;
            MCheckBox.Checked = true;
            DCheckBox.Checked = true;
        }

        /// <summary>
        /// プラスマイナスクリアボタン押下処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PMClearButton_Click(object sender, EventArgs e)
        {
            PlusOrMinusTextBox.Text = string.Empty;
        }

        /// <summary>
        /// 掛け算クリアボタン押下処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MClearButton_Click(object sender, EventArgs e)
        {
            MultiplicationTextBox.Text = string.Empty;
        }

        /// <summary>
        /// 割り算クリアボタン押下処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DClearButton_Click(object sender, EventArgs e)
        {
            DivisionTextBox.Text = string.Empty;
        }

        /// <summary>
        /// 数値フォーマット変更ボタン押下処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NumberFormatButton_Click(object sender, EventArgs e)
        {
            if (COMMA_NUMBER_VIEW_FORMAT == NumberFormatButton.Text)
            {
                NumberFormatButton.Text = NUMBER_VIEW_FORMAT;
            }
            else
            {
                NumberFormatButton.Text = COMMA_NUMBER_VIEW_FORMAT;
            }
        }

        /// <summary>
        /// 計算結果ボタン押下処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CEqualButton_Click(object sender, EventArgs e)
        {
            double sum = 0;

            if (PMCheckBox.Checked)
            {
                sum += this.Calculation(PlusOrMinusTextBox.Text, CalculationType.MC);
            }

            if (MCheckBox.Checked)
            {
                sum += this.Calculation(MultiplicationTextBox.Text, CalculationType.M);
            }

            if (DCheckBox.Checked)
            {
                sum += this.Calculation(DivisionTextBox.Text, CalculationType.D);
            }

            if (COMMA_NUMBER_VIEW_FORMAT == NumberFormatButton.Text)
            {
                CalculationTextBox.Text = string.Format(COMMA_NUMBER_FORMAT, sum);
            }
            else
            {
                CalculationTextBox.Text = sum.ToString();
            }
        }

        /// <summary>
        /// 計算処理
        /// </summary>
        /// <param name="text">入力値</param>
        /// <param name="calculationType">計算種別</param>
        /// <returns></returns>
        private double Calculation(string text, CalculationType calculationType)
        {
            double sum = 0;

            if (string.IsNullOrEmpty(text))
            {
                return sum;
            }

            string[] texts = text.Split(new string[] { NEW_LINE }, StringSplitOptions.None);
            int cnt = texts.Length;

            List<double> numList = new List<double>();

            if (CalculationType.M == calculationType || CalculationType.D == calculationType)
            {
                bool isFirst = true;

                for (int i = 0; i < cnt; i++)
                {
                    if (!isFirst && !decimal.TryParse(texts[i], out _))
                    {
                        continue;
                    }

                    double.TryParse(texts[i], out double num);

                    if (isFirst && 0 == num)
                    {
                        continue;
                    }
                    else if (isFirst && 0 != num)
                    {
                        numList.Add(num);
                        isFirst = false;
                    }
                    else
                    {
                        if (CalculationType.M == calculationType || 
                            (CalculationType.D == calculationType && 0 != num))
                        {
                            numList.Add(num);
                        }
                    }
                }

                cnt = numList.Count;
            }

            if (CalculationType.MC == calculationType)
            {
                foreach (string data in texts)
                {

                    double.TryParse(data, out double num);

                    sum += num;
                }
            }
            else if (CalculationType.M == calculationType)
            {
                if (cnt > 1)
                {
                    sum = numList[0];

                    for (int i = 1; i < cnt; i++)
                    {
                        sum *= numList[i];
                    }
                }
            }
            else if (CalculationType.D == calculationType)
            {
                if (cnt > 1)
                {
                    sum = numList[0];

                    for (int i = 1; i < cnt; i++)
                    {
                        sum /= numList[i];
                    }
                }
            }

            return sum;
        }
    }
}
