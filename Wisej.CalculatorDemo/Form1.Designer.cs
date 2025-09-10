using System;
using Wisej.Web;

namespace Wisej.CalculatorDemo
{
    partial class Form1
    {
        private TableLayoutPanel tableLayoutPanel1;
        private TextBox txtDisplay;
        private TableLayoutPanel tableLayoutPanel2;
        private Button btnCopy;
        private Button btnReset;
        private Button btnClear;
        private Button btnDiv;
        private Button btn7;
        private Button btn8;
        private Button btn9;
        private Button btnMul;
        private Button btn4;
        private Button btn5;
        private Button btn6;
        private Button btnSub;
        private Button btn1;
        private Button btn2;
        private Button btn3;
        private Button btnAdd;
        private Button btn0;
        private Button btnDecimal;
        private Button btnRes;

        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new TableLayoutPanel();
            this.txtDisplay = new TextBox();
            this.tableLayoutPanel2 = new TableLayoutPanel();
            this.btnCopy = new Button();
            this.btnReset = new Button();
            this.btnClear = new Button();
            this.btnDiv = new Button();
            this.btn7 = new Button();
            this.btn8 = new Button();
            this.btn9 = new Button();
            this.btnMul = new Button();
            this.btn4 = new Button();
            this.btn5 = new Button();
            this.btn6 = new Button();
            this.btnSub = new Button();
            this.btn1 = new Button();
            this.btn2 = new Button();
            this.btn3 = new Button();
            this.btnAdd = new Button();
            this.btn0 = new Button();
            this.btnDecimal = new Button();
            this.btnRes = new Button();
            this.SuspendLayout();
            // tableLayoutPanel1
            this.tableLayoutPanel1.Dock = DockStyle.Fill;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 80F));
            this.tableLayoutPanel1.Controls.Add(this.txtDisplay, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            // txtDisplay
            this.txtDisplay.Dock = DockStyle.Fill;
            this.txtDisplay.ReadOnly = true;
            this.txtDisplay.TextAlign = HorizontalAlignment.Right;
            // tableLayoutPanel2
            this.tableLayoutPanel2.Dock = DockStyle.Fill;
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.RowCount = 5;
            for (int i = 0; i < 4; i++)
                this.tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            for (int i = 0; i < 5; i++)
                this.tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            // buttons
            Button[] numericButtons = { btn0, btn1, btn2, btn3, btn4, btn5, btn6, btn7, btn8, btn9 };
            foreach (var b in numericButtons)
            {
                b.Dock = DockStyle.Fill;
                b.Click += BtnNum_Click;
            }
            this.btnCopy.Text = "Copy"; this.btnCopy.Dock = DockStyle.Fill; this.btnCopy.Click += BtnCopy_Click;
            this.btnReset.Text = "Reset"; this.btnReset.Dock = DockStyle.Fill; this.btnReset.Click += BtnReset_Click;
            this.btnClear.Text = "Clear"; this.btnClear.Dock = DockStyle.Fill; this.btnClear.Click += BtnClear_Click;
            this.btnDiv.Text = "/"; this.btnDiv.Dock = DockStyle.Fill; this.btnDiv.Click += BtnDiv_Click;
            this.btn7.Text = "7"; this.btn8.Text = "8"; this.btn9.Text = "9";
            this.btnMul.Text = "*"; this.btnMul.Dock = DockStyle.Fill; this.btnMul.Click += BtnMul_Click;
            this.btn4.Text = "4"; this.btn5.Text = "5"; this.btn6.Text = "6";
            this.btnSub.Text = "-"; this.btnSub.Dock = DockStyle.Fill; this.btnSub.Click += BtnSub_Click;
            this.btn1.Text = "1"; this.btn2.Text = "2"; this.btn3.Text = "3";
            this.btnAdd.Text = "+"; this.btnAdd.Dock = DockStyle.Fill; this.btnAdd.Click += BtnAdd_Click;
            this.btn0.Text = "0";
            this.btnDecimal.Text = "."; this.btnDecimal.Dock = DockStyle.Fill; this.btnDecimal.Click += BtnDecimal_Click;
            this.btnRes.Text = "="; this.btnRes.Dock = DockStyle.Fill; this.btnRes.Click += BtnRes_Click;
            // add buttons to tableLayoutPanel2
            this.tableLayoutPanel2.Controls.Add(this.btnCopy, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnReset, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnClear, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnDiv, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.btn7, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.btn8, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.btn9, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.btnMul, 3, 1);
            this.tableLayoutPanel2.Controls.Add(this.btn4, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.btn5, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.btn6, 2, 2);
            this.tableLayoutPanel2.Controls.Add(this.btnSub, 3, 2);
            this.tableLayoutPanel2.Controls.Add(this.btn1, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.btn2, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.btn3, 2, 3);
            this.tableLayoutPanel2.Controls.Add(this.btnAdd, 3, 3);
            this.tableLayoutPanel2.Controls.Add(this.btn0, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.btnDecimal, 2, 4);
            this.tableLayoutPanel2.Controls.Add(this.btnRes, 3, 4);
            // Form1
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 400);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Text = "Calculator";
            this.ResumeLayout(false);
        }
    }
}
