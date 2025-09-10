namespace Wisej.CalculatorDemo
{
	partial class Page1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Wisej.NET Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
                private void InitializeComponent()
                {
                        this.tableLayoutPanel1 = new Wisej.Web.TableLayoutPanel();
                        this.txtDisplay = new Wisej.Web.TextBox();
                        this.tableLayoutPanel2 = new Wisej.Web.TableLayoutPanel();
                        this.btnRes = new Wisej.Web.Button();
                        this.btn0 = new Wisej.Web.Button();
                        this.btnAdd = new Wisej.Web.Button();
                        this.btn3 = new Wisej.Web.Button();
                        this.btn2 = new Wisej.Web.Button();
                        this.btn1 = new Wisej.Web.Button();
                        this.btnSub = new Wisej.Web.Button();
                        this.btn6 = new Wisej.Web.Button();
                        this.btn5 = new Wisej.Web.Button();
                        this.btn4 = new Wisej.Web.Button();
                        this.btnMul = new Wisej.Web.Button();
                        this.btn9 = new Wisej.Web.Button();
                        this.btn8 = new Wisej.Web.Button();
                        this.btnDiv = new Wisej.Web.Button();
                        this.btnClear = new Wisej.Web.Button();
                        this.btnReset = new Wisej.Web.Button();
                        this.btnCopy = new Wisej.Web.Button();
                        this.btn7 = new Wisej.Web.Button();
                        this.btnDecimal = new Wisej.Web.Button();
                        this.tableLayoutPanel1.SuspendLayout();
                        this.tableLayoutPanel2.SuspendLayout();
                        this.SuspendLayout();
                        // 
                        // tableLayoutPanel1
                        // 
                        this.tableLayoutPanel1.ColumnCount = 1;
                        this.tableLayoutPanel1.ColumnStyles.Add(new Wisej.Web.ColumnStyle(Wisej.Web.SizeType.Percent, 100F));
                        this.tableLayoutPanel1.Controls.Add(this.txtDisplay, 0, 0);
                        this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
                        this.tableLayoutPanel1.Dock = Wisej.Web.DockStyle.Fill;
                        this.tableLayoutPanel1.RowCount = 2;
                        this.tableLayoutPanel1.RowStyles.Add(new Wisej.Web.RowStyle(Wisej.Web.SizeType.Percent, 20F));
                        this.tableLayoutPanel1.RowStyles.Add(new Wisej.Web.RowStyle(Wisej.Web.SizeType.Percent, 80F));
                        this.tableLayoutPanel1.TabIndex = 0;
                        // 
                        // txtDisplay
                        // 
                        this.txtDisplay.Dock = Wisej.Web.DockStyle.Fill;
                        this.txtDisplay.ReadOnly = true;
                        this.txtDisplay.TextAlign = Wisej.Web.HorizontalAlignment.Right;
                        // 
                        // tableLayoutPanel2
                        // 
                        this.tableLayoutPanel2.ColumnCount = 4;
                        this.tableLayoutPanel2.ColumnStyles.Add(new Wisej.Web.ColumnStyle(Wisej.Web.SizeType.Percent, 25F));
                        this.tableLayoutPanel2.ColumnStyles.Add(new Wisej.Web.ColumnStyle(Wisej.Web.SizeType.Percent, 25F));
                        this.tableLayoutPanel2.ColumnStyles.Add(new Wisej.Web.ColumnStyle(Wisej.Web.SizeType.Percent, 25F));
                        this.tableLayoutPanel2.ColumnStyles.Add(new Wisej.Web.ColumnStyle(Wisej.Web.SizeType.Percent, 25F));
                        this.tableLayoutPanel2.Controls.Add(this.btnRes, 3, 4);
                        this.tableLayoutPanel2.Controls.Add(this.btn0, 1, 4);
                        this.tableLayoutPanel2.Controls.Add(this.btnAdd, 3, 3);
                        this.tableLayoutPanel2.Controls.Add(this.btn3, 2, 3);
                        this.tableLayoutPanel2.Controls.Add(this.btn2, 1, 3);
                        this.tableLayoutPanel2.Controls.Add(this.btn1, 0, 3);
                        this.tableLayoutPanel2.Controls.Add(this.btnSub, 3, 2);
                        this.tableLayoutPanel2.Controls.Add(this.btn6, 2, 2);
                        this.tableLayoutPanel2.Controls.Add(this.btn5, 1, 2);
                        this.tableLayoutPanel2.Controls.Add(this.btn4, 0, 2);
                        this.tableLayoutPanel2.Controls.Add(this.btnMul, 3, 1);
                        this.tableLayoutPanel2.Controls.Add(this.btn9, 2, 1);
                        this.tableLayoutPanel2.Controls.Add(this.btn8, 1, 1);
                        this.tableLayoutPanel2.Controls.Add(this.btnDiv, 3, 0);
                        this.tableLayoutPanel2.Controls.Add(this.btnClear, 2, 0);
                        this.tableLayoutPanel2.Controls.Add(this.btnReset, 1, 0);
                        this.tableLayoutPanel2.Controls.Add(this.btnCopy, 0, 0);
                        this.tableLayoutPanel2.Controls.Add(this.btn7, 0, 1);
                        this.tableLayoutPanel2.Controls.Add(this.btnDecimal, 2, 4);
                        this.tableLayoutPanel2.Dock = Wisej.Web.DockStyle.Fill;
                        this.tableLayoutPanel2.RowCount = 5;
                        this.tableLayoutPanel2.RowStyles.Add(new Wisej.Web.RowStyle(Wisej.Web.SizeType.Percent, 20F));
                        this.tableLayoutPanel2.RowStyles.Add(new Wisej.Web.RowStyle(Wisej.Web.SizeType.Percent, 20F));
                        this.tableLayoutPanel2.RowStyles.Add(new Wisej.Web.RowStyle(Wisej.Web.SizeType.Percent, 20F));
                        this.tableLayoutPanel2.RowStyles.Add(new Wisej.Web.RowStyle(Wisej.Web.SizeType.Percent, 20F));
                        this.tableLayoutPanel2.RowStyles.Add(new Wisej.Web.RowStyle(Wisej.Web.SizeType.Percent, 20F));
                        this.tableLayoutPanel2.TabIndex = 1;
                        // 
                        // btnRes
                        // 
                        this.btnRes.Dock = Wisej.Web.DockStyle.Fill;
                        this.btnRes.Text = "=";
                        this.btnRes.Click += new System.EventHandler(this.BtnRes_Click);
                        // 
                        // btn0
                        // 
                        this.btn0.Dock = Wisej.Web.DockStyle.Fill;
                        this.btn0.Text = "0";
                        this.btn0.Click += new System.EventHandler(this.BtnNum_Click);
                        // 
                        // btnAdd
                        // 
                        this.btnAdd.Dock = Wisej.Web.DockStyle.Fill;
                        this.btnAdd.Text = "+";
                        this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
                        // 
                        // btn3
                        // 
                        this.btn3.Dock = Wisej.Web.DockStyle.Fill;
                        this.btn3.Text = "3";
                        this.btn3.Click += new System.EventHandler(this.BtnNum_Click);
                        // 
                        // btn2
                        // 
                        this.btn2.Dock = Wisej.Web.DockStyle.Fill;
                        this.btn2.Text = "2";
                        this.btn2.Click += new System.EventHandler(this.BtnNum_Click);
                        // 
                        // btn1
                        // 
                        this.btn1.Dock = Wisej.Web.DockStyle.Fill;
                        this.btn1.Text = "1";
                        this.btn1.Click += new System.EventHandler(this.BtnNum_Click);
                        // 
                        // btnSub
                        // 
                        this.btnSub.Dock = Wisej.Web.DockStyle.Fill;
                        this.btnSub.Text = "-";
                        this.btnSub.Click += new System.EventHandler(this.BtnSub_Click);
                        // 
                        // btn6
                        // 
                        this.btn6.Dock = Wisej.Web.DockStyle.Fill;
                        this.btn6.Text = "6";
                        this.btn6.Click += new System.EventHandler(this.BtnNum_Click);
                        // 
                        // btn5
                        // 
                        this.btn5.Dock = Wisej.Web.DockStyle.Fill;
                        this.btn5.Text = "5";
                        this.btn5.Click += new System.EventHandler(this.BtnNum_Click);
                        // 
                        // btn4
                        // 
                        this.btn4.Dock = Wisej.Web.DockStyle.Fill;
                        this.btn4.Text = "4";
                        this.btn4.Click += new System.EventHandler(this.BtnNum_Click);
                        // 
                        // btnMul
                        // 
                        this.btnMul.Dock = Wisej.Web.DockStyle.Fill;
                        this.btnMul.Text = "*";
                        this.btnMul.Click += new System.EventHandler(this.BtnMul_Click);
                        // 
                        // btn9
                        // 
                        this.btn9.Dock = Wisej.Web.DockStyle.Fill;
                        this.btn9.Text = "9";
                        this.btn9.Click += new System.EventHandler(this.BtnNum_Click);
                        // 
                        // btn8
                        // 
                        this.btn8.Dock = Wisej.Web.DockStyle.Fill;
                        this.btn8.Text = "8";
                        this.btn8.Click += new System.EventHandler(this.BtnNum_Click);
                        // 
                        // btnDiv
                        // 
                        this.btnDiv.Dock = Wisej.Web.DockStyle.Fill;
                        this.btnDiv.Text = "/";
                        this.btnDiv.Click += new System.EventHandler(this.BtnDiv_Click);
                        // 
                        // btnClear
                        // 
                        this.btnClear.Dock = Wisej.Web.DockStyle.Fill;
                        this.btnClear.Text = "Clear";
                        this.btnClear.Click += new System.EventHandler(this.BtnClear_Click);
                        // 
                        // btnReset
                        // 
                        this.btnReset.Dock = Wisej.Web.DockStyle.Fill;
                        this.btnReset.Text = "Reset";
                        this.btnReset.Click += new System.EventHandler(this.BtnReset_Click);
                        // 
                        // btnCopy
                        // 
                        this.btnCopy.Dock = Wisej.Web.DockStyle.Fill;
                        this.btnCopy.Text = "Copy";
                        this.btnCopy.Click += new System.EventHandler(this.BtnCopy_Click);
                        // 
                        // btn7
                        // 
                        this.btn7.Dock = Wisej.Web.DockStyle.Fill;
                        this.btn7.Text = "7";
                        this.btn7.Click += new System.EventHandler(this.BtnNum_Click);
                        // 
                        // btnDecimal
                        // 
                        this.btnDecimal.Dock = Wisej.Web.DockStyle.Fill;
                        this.btnDecimal.Text = ".";
                        this.btnDecimal.Click += new System.EventHandler(this.BtnDecimal_Click);
                        // 
                        // Page1
                        // 
                        this.Controls.Add(this.tableLayoutPanel1);
                        this.Name = "Page1";
                        this.Size = new System.Drawing.Size(300, 400);
                        this.tableLayoutPanel1.ResumeLayout(false);
                        this.tableLayoutPanel1.PerformLayout();
                        this.tableLayoutPanel2.ResumeLayout(false);
                        this.ResumeLayout(false);
                }

                #endregion

                private Wisej.Web.TableLayoutPanel tableLayoutPanel1;
                private Wisej.Web.TextBox txtDisplay;
                private Wisej.Web.TableLayoutPanel tableLayoutPanel2;
                private Wisej.Web.Button btnRes;
                private Wisej.Web.Button btn0;
                private Wisej.Web.Button btnAdd;
                private Wisej.Web.Button btn3;
                private Wisej.Web.Button btn2;
                private Wisej.Web.Button btn1;
                private Wisej.Web.Button btnSub;
                private Wisej.Web.Button btn6;
                private Wisej.Web.Button btn5;
                private Wisej.Web.Button btn4;
                private Wisej.Web.Button btnMul;
                private Wisej.Web.Button btn9;
                private Wisej.Web.Button btn8;
                private Wisej.Web.Button btnDiv;
                private Wisej.Web.Button btnClear;
                private Wisej.Web.Button btnReset;
                private Wisej.Web.Button btnCopy;
                private Wisej.Web.Button btn7;
                private Wisej.Web.Button btnDecimal;

        }
}
