using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // 全域變數
        float firstNumber, secondNumber; // firstNumber 儲存第一個數字，secondNumber 儲存第二個數字
        int operators = -1; // 記錄選擇哪一種運算符號？0:加、1:減、2:乘、3:除、-1:重新設定
        private void Add_Number(string _number)
        {
            if (txtNumber.Text == "0")
                txtNumber.Text = "";
            txtNumber.Text = txtNumber.Text + _number;
        }
        private void btnOne_Click(object sender, EventArgs e)
        {
            Add_Number("1");
        }

        private void btnTwo_Click(object sender, EventArgs e)
        {
            Add_Number("2");
        }

        private void btnThree_Click(object sender, EventArgs e)
        {
            Add_Number("3");
        }

        private void btnFour_Click(object sender, EventArgs e)
        {
            Add_Number("4");
        }

        private void btnFive_Click(object sender, EventArgs e)
        {
            Add_Number("5");
        }

        private void btnSix_Click(object sender, EventArgs e)
        {
            Add_Number("6");
        }

        private void btnSeven_Click(object sender, EventArgs e)
        {
            Add_Number("7");
        }

        private void btnEight_Click(object sender, EventArgs e)
        {
            Add_Number("8");
        }

        private void btnNine_Click(object sender, EventArgs e)
        {
            Add_Number("9");
        }

        private void btnZero_Click(object sender, EventArgs e)
        {
            Add_Number("0");
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            Select_Operator(0);
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            Select_Operator(1);
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            Select_Operator(2);
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            Select_Operator(3);
        }

        private void Select_Operator(int _operator)
        {
            firstNumber = Convert.ToSingle(txtNumber.Text); //將輸入文字框轉換成浮點數，存入第一個數字的全域變數
            txtNumber.Text = "0"; //重新將輸入文字框重新設定為0
            operators = _operator; //選擇「加」號
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            float finalResults = 0f; //宣告最後計算結果變數
            secondNumber = Convert.ToSingle(txtNumber.Text); //將輸入文字框轉換成浮點數，存入第二個數字的全域變數

            //依照四則運算符號的選擇，進行加減乘除
            switch (operators)
            {
                case 0:
                    finalResults = firstNumber + secondNumber;
                    break;
                case 1:
                    finalResults = firstNumber - secondNumber;
                    break;
                case 2:
                    finalResults = firstNumber * secondNumber;
                    break;
                case 3:
                    finalResults = firstNumber / secondNumber;
                    break;
            }

            txtNumber.Text = string.Format("{0:0.##########}", finalResults); //在輸入文字框中，顯示最後計算結果，並且轉換成格式化的字串內容

            //重置所有全域變數
            firstNumber = 0f;
            secondNumber = 0f;
            operators = -1;
        }

        private void btnDot_Click(object sender, EventArgs e)
        {
            // 確認輸入文字框中完全沒有小數點
            if (txtNumber.Text.IndexOf(".") == -1)
                txtNumber.Text = txtNumber.Text + ".";
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtNumber.Text = "0";
            firstNumber = 0f;
            secondNumber = 0f;
            operators = -1;
        }
        private void btnBackspace_Click(object sender, EventArgs e)
        {
            if (txtNumber.Text.Length > 0)
            {
                txtNumber.Text = txtNumber.Text.Substring(0, txtNumber.Text.Length - 1);
            }
            else
            {
                txtNumber.Text = "0";
            }
        }

        private void btnPercentage_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtNumber.Text))
            {
                float number = float.Parse(txtNumber.Text);
                number = number / 100;
                txtNumber.Text = number.ToString();
            }
        }

        private Button btnBackspace;
        private Button btnPercentage;
        private Button btnClear;
        private Button btnDot;
        private Button btnZero;
        private Button button12;
        private Button btnTwo;
        private Button btnOne;
        private Button btnEqual;
        private Button button9;
        private Button btnAdd;
        private Button btnThree;
        private Button btnMinus;
        private Button btnFour;
        private Button btnFive;
        private Button btnSeven;
        private Button btnEight;
        private Button btnSix;
        private Button btnNine;
        private Button btnPlus;
        private Button btnDivide;

        private void InitializeComponent()
        {
            this.btnBackspace = new System.Windows.Forms.Button();
            this.btnPercentage = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDot = new System.Windows.Forms.Button();
            this.btnZero = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.btnTwo = new System.Windows.Forms.Button();
            this.btnOne = new System.Windows.Forms.Button();
            this.btnEqual = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnThree = new System.Windows.Forms.Button();
            this.btnMinus = new System.Windows.Forms.Button();
            this.btnFour = new System.Windows.Forms.Button();
            this.btnFive = new System.Windows.Forms.Button();
            this.btnSeven = new System.Windows.Forms.Button();
            this.btnEight = new System.Windows.Forms.Button();
            this.btnSix = new System.Windows.Forms.Button();
            this.btnNine = new System.Windows.Forms.Button();
            this.btnPlus = new System.Windows.Forms.Button();
            this.btnDivide = new System.Windows.Forms.Button();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnBackspace
            // 
            this.btnBackspace.Location = new System.Drawing.Point(448, 340);
            this.btnBackspace.Name = "btnBackspace";
            this.btnBackspace.Size = new System.Drawing.Size(75, 23);
            this.btnBackspace.TabIndex = 29;
            this.btnBackspace.Text = "<-";
            this.btnBackspace.UseVisualStyleBackColor = true;
            this.btnBackspace.Click += new System.EventHandler(this.btnBackspace_Click);
            // 
            // btnPercentage
            // 
            this.btnPercentage.Location = new System.Drawing.Point(448, 268);
            this.btnPercentage.Name = "btnPercentage";
            this.btnPercentage.Size = new System.Drawing.Size(75, 23);
            this.btnPercentage.TabIndex = 28;
            this.btnPercentage.Text = "%";
            this.btnPercentage.UseVisualStyleBackColor = true;
            this.btnPercentage.Click += new System.EventHandler(this.btnPercentage_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(448, 202);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 27;
            this.btnClear.Text = "AC";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnDot
            // 
            this.btnDot.Location = new System.Drawing.Point(549, 402);
            this.btnDot.Name = "btnDot";
            this.btnDot.Size = new System.Drawing.Size(75, 23);
            this.btnDot.TabIndex = 26;
            this.btnDot.Text = ".";
            this.btnDot.UseVisualStyleBackColor = true;
            this.btnDot.Click += new System.EventHandler(this.btnDot_Click);
            // 
            // btnZero
            // 
            this.btnZero.Location = new System.Drawing.Point(666, 403);
            this.btnZero.Name = "btnZero";
            this.btnZero.Size = new System.Drawing.Size(75, 23);
            this.btnZero.TabIndex = 24;
            this.btnZero.Text = "0";
            this.btnZero.UseVisualStyleBackColor = true;
            this.btnZero.Click += new System.EventHandler(this.btnZero_Click);
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(666, 403);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(75, 23);
            this.button12.TabIndex = 23;
            this.button12.Text = "button3";
            this.button12.UseVisualStyleBackColor = true;
            // 
            // btnTwo
            // 
            this.btnTwo.Location = new System.Drawing.Point(666, 341);
            this.btnTwo.Name = "btnTwo";
            this.btnTwo.Size = new System.Drawing.Size(75, 23);
            this.btnTwo.TabIndex = 22;
            this.btnTwo.Text = "2";
            this.btnTwo.UseVisualStyleBackColor = true;
            this.btnTwo.Click += new System.EventHandler(this.btnTwo_Click);
            // 
            // btnOne
            // 
            this.btnOne.Location = new System.Drawing.Point(549, 341);
            this.btnOne.Name = "btnOne";
            this.btnOne.Size = new System.Drawing.Size(75, 23);
            this.btnOne.TabIndex = 21;
            this.btnOne.Text = "1";
            this.btnOne.UseVisualStyleBackColor = true;
            this.btnOne.Click += new System.EventHandler(this.btnOne_Click);
            // 
            // btnEqual
            // 
            this.btnEqual.Location = new System.Drawing.Point(782, 403);
            this.btnEqual.Name = "btnEqual";
            this.btnEqual.Size = new System.Drawing.Size(75, 23);
            this.btnEqual.TabIndex = 20;
            this.btnEqual.Text = "=";
            this.btnEqual.UseVisualStyleBackColor = true;
            this.btnEqual.Click += new System.EventHandler(this.btnEqual_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(666, 341);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(75, 23);
            this.button9.TabIndex = 25;
            this.button9.Text = "button3";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(890, 403);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 19;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnThree
            // 
            this.btnThree.Location = new System.Drawing.Point(782, 341);
            this.btnThree.Name = "btnThree";
            this.btnThree.Size = new System.Drawing.Size(75, 23);
            this.btnThree.TabIndex = 18;
            this.btnThree.Text = "3";
            this.btnThree.UseVisualStyleBackColor = true;
            this.btnThree.Click += new System.EventHandler(this.btnThree_Click);
            // 
            // btnMinus
            // 
            this.btnMinus.Location = new System.Drawing.Point(890, 341);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(75, 23);
            this.btnMinus.TabIndex = 17;
            this.btnMinus.Text = "-";
            this.btnMinus.UseVisualStyleBackColor = true;
            this.btnMinus.Click += new System.EventHandler(this.btnMinus_Click);
            // 
            // btnFour
            // 
            this.btnFour.Location = new System.Drawing.Point(549, 269);
            this.btnFour.Name = "btnFour";
            this.btnFour.Size = new System.Drawing.Size(75, 23);
            this.btnFour.TabIndex = 16;
            this.btnFour.Text = "4";
            this.btnFour.UseVisualStyleBackColor = true;
            this.btnFour.Click += new System.EventHandler(this.btnFour_Click);
            // 
            // btnFive
            // 
            this.btnFive.Location = new System.Drawing.Point(666, 269);
            this.btnFive.Name = "btnFive";
            this.btnFive.Size = new System.Drawing.Size(75, 23);
            this.btnFive.TabIndex = 15;
            this.btnFive.Text = "5";
            this.btnFive.UseVisualStyleBackColor = true;
            this.btnFive.Click += new System.EventHandler(this.btnFive_Click);
            // 
            // btnSeven
            // 
            this.btnSeven.Location = new System.Drawing.Point(549, 202);
            this.btnSeven.Name = "btnSeven";
            this.btnSeven.Size = new System.Drawing.Size(75, 23);
            this.btnSeven.TabIndex = 11;
            this.btnSeven.Text = "7";
            this.btnSeven.UseVisualStyleBackColor = true;
            this.btnSeven.Click += new System.EventHandler(this.btnSeven_Click);
            // 
            // btnEight
            // 
            this.btnEight.Location = new System.Drawing.Point(666, 202);
            this.btnEight.Name = "btnEight";
            this.btnEight.Size = new System.Drawing.Size(75, 23);
            this.btnEight.TabIndex = 10;
            this.btnEight.Text = "8";
            this.btnEight.UseVisualStyleBackColor = true;
            this.btnEight.Click += new System.EventHandler(this.btnEight_Click);
            // 
            // btnSix
            // 
            this.btnSix.Location = new System.Drawing.Point(782, 269);
            this.btnSix.Name = "btnSix";
            this.btnSix.Size = new System.Drawing.Size(75, 23);
            this.btnSix.TabIndex = 14;
            this.btnSix.Text = "6";
            this.btnSix.UseVisualStyleBackColor = true;
            this.btnSix.Click += new System.EventHandler(this.btnSix_Click);
            // 
            // btnNine
            // 
            this.btnNine.Location = new System.Drawing.Point(782, 202);
            this.btnNine.Name = "btnNine";
            this.btnNine.Size = new System.Drawing.Size(75, 23);
            this.btnNine.TabIndex = 9;
            this.btnNine.Text = "9";
            this.btnNine.UseVisualStyleBackColor = true;
            this.btnNine.Click += new System.EventHandler(this.btnNine_Click);
            // 
            // btnPlus
            // 
            this.btnPlus.Location = new System.Drawing.Point(890, 269);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(75, 23);
            this.btnPlus.TabIndex = 13;
            this.btnPlus.Text = "*";
            this.btnPlus.UseVisualStyleBackColor = true;
            this.btnPlus.Click += new System.EventHandler(this.btnPlus_Click);
            // 
            // btnDivide
            // 
            this.btnDivide.Location = new System.Drawing.Point(890, 202);
            this.btnDivide.Name = "btnDivide";
            this.btnDivide.Size = new System.Drawing.Size(75, 23);
            this.btnDivide.TabIndex = 12;
            this.btnDivide.Text = "/";
            this.btnDivide.UseVisualStyleBackColor = true;
            this.btnDivide.Click += new System.EventHandler(this.btnDivide_Click);
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(448, 148);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(517, 25);
            this.txtNumber.TabIndex = 8;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(1599, 763);
            this.Controls.Add(this.btnBackspace);
            this.Controls.Add(this.btnPercentage);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnDot);
            this.Controls.Add(this.btnZero);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.btnTwo);
            this.Controls.Add(this.btnOne);
            this.Controls.Add(this.btnEqual);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnThree);
            this.Controls.Add(this.btnMinus);
            this.Controls.Add(this.btnFour);
            this.Controls.Add(this.btnFive);
            this.Controls.Add(this.btnSeven);
            this.Controls.Add(this.btnEight);
            this.Controls.Add(this.btnSix);
            this.Controls.Add(this.btnNine);
            this.Controls.Add(this.btnPlus);
            this.Controls.Add(this.btnDivide);
            this.Controls.Add(this.txtNumber);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private TextBox txtNumber;
    }
}
