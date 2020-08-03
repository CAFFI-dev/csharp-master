using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Windows.Forms;

namespace JustAFunProgram
{
    public partial class Form1 : Form
    {
        public bool isNotepadChecked = false;
        public bool isCalcChecked = false;
        public bool isCmdChecked = false;
        public bool isShutdown = false, isRestart = false;
        public bool toBSoD = false;
        Random rnd = new Random();

        public Form1()
        {
            InitializeComponent();
        }
        public bool RandomBool()
        {
            if (rnd.Next(0, 2) == 0)
            {
                return false;
            }
            else return true;
        }
        public void Calc(int howMany)
        {
            for (int i = 0; i < howMany; i++)
            {
                Process.Start("calc.exe");
            }
        }

        public void Notepad(int howMany)
        {
            for (int i = 0; i < howMany; i++)
            {
                Process.Start("notepad.exe");
            }
        }

        public void Cmd(int howMany)
        {
            for (int i = 0; i < howMany; i++)
            {
                Process.Start("cmd.exe");
            }
        }
        public void Shutdown(bool withRestart, int time)
        {
            Process.EnterDebugMode();
            Process.
        }

        public void BsodActive()
        { 
            System.
        }
        private void calc_CheckedChanged(object sender, EventArgs e)
        {
            isCalcChecked = calc.Checked;
        }

        private void notepad_CheckedChanged(object sender, EventArgs e)
        {
            isNotepadChecked = notepad.Checked;
        }

        private void cmd_CheckedChanged(object sender, EventArgs e)
        {
            isCmdChecked = cmd.Checked;
        }

        private void restartPC_CheckedChanged(object sender, EventArgs e)
        {
            isRestart = restartPC.Checked;
            if (isRestart)
            {
                isShutdown = false;
                shutdownPC.Checked = false;
                toBSoD = false;
                BSoD.Checked = false;
            }
        }

        private void BSoD_CheckedChanged(object sender, EventArgs e)
        {
            toBSoD = BSoD.Checked;
            if (toBSoD)
            {
                isShutdown = false;
                shutdownPC.Checked = false;
                isRestart = false;
                restartPC.Checked = false;
            }
        }

        private void shutdownPC_CheckedChanged(object sender, EventArgs e)
        {
            isShutdown = shutdownPC.Checked;
            if (isShutdown)
            {
                isRestart = false;
                restartPC.Checked = false;
                toBSoD = false;
                BSoD.Checked = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Рандомизировать
            calc.Checked = RandomBool();
            notepad.Checked = RandomBool();
            cmd.Checked = RandomBool();
            isCalcChecked = calc.Checked;
            isNotepadChecked = notepad.Checked;
            isCmdChecked = cmd.Checked;

            calcAmount.Text = rnd.Next(0, 30).ToString();
            notepadAmount.Text = rnd.Next(0, 30).ToString();
            cmdAmount.Text = rnd.Next(0, 30).ToString();
        }
        private void Применить_Click(object sender, EventArgs e)
        {
            //Применить все изменения
            if (isCalcChecked)
            {
                Calc(Int32.Parse(calcAmount.Text));
            }

            if (isNotepadChecked)
            {
                Notepad(Int32.Parse(notepadAmount.Text));
            }

            if (isCmdChecked)
            {
                Cmd(Int32.Parse(cmdAmount.Text));
            }

            if (toQuitProgram.Checked)
            {
                this.Close();
            }
        }
    }
}
