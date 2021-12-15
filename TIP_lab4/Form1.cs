using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TIP_lab4
{
    public partial class Form1 : Form
    {
        private Dictionary<string, string> dic;
        private SortedSet<string> ss;
        public Form1()
        {
            dic = new Dictionary<string, string>();
            ss = new SortedSet<string>();
            InitializeComponent();
            defaultMachineLoader();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox3.Text != "" && textBox4.Text != "" && textBox5.Text != "" && textBox6.Text != "" && textBox7.Text != "")
            {
                try
                {                       
                    dic.Add(textBox3.Text + "," + textBox4.Text + "," + textBox5.Text, textBox6.Text + "," + textBox7.Text);
                    tableTranslationsListBox.Items.Add(label1.Text + textBox3.Text + "," + textBox4.Text + "," + textBox5.Text + label4.Text + textBox6.Text + "," + textBox7.Text + ")");
                }
                catch(ArgumentException){
                    return;
                }
                
            } else {
                MessageBox.Show("Проверте ввод данных! Некое поле пустое!");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(tableTranslationsListBox.SelectedIndex != -1)
            {
                string key = tableTranslationsListBox.SelectedItems[0].ToString();
                var temp = key.Split(label4.Text);
                key = temp[0].Replace(label1.Text, string.Empty);              
                dic.Remove(key);              
                tableTranslationsListBox.Items.RemoveAt(tableTranslationsListBox.SelectedIndex);
            }
                
        }

        private void button2_Click(object sender, EventArgs e)
        {
            showResultTextBox.Text = "";
            string chain = inputStringTextBox.Text;
            Stack<string> st = new Stack<string>();
            st.Push("Z");
            string currentState = "0";
            string finalState = "f";
            while (true)
            {
                string key = "";
                try
                {
                    key = currentState + "," + chain.Substring(0, 1) + "," + st.Peek();
                }catch (ArgumentOutOfRangeException)
                {
                    key = currentState + ",*,"  + st.Peek();
                    
                }
                catch (InvalidOperationException)
                {
                    MessageBox.Show("sadsad");
                }
                try
                {
                    chain = chain.Substring(1, chain.Length - 1);
                }
                catch (ArgumentOutOfRangeException)
                {
                    chain = "*";
                    if (st.Count != 1)
                    {
                        MessageBox.Show("Цепочка кончилась, а стек не пустой!");
                        resultLabel.Text = "Не принадлежит";
                        return;
                    }
                }

                if (!dic.ContainsKey(key))
                {
                    
                    MessageBox.Show("Нет такого перехода!");
                    showResultTextBox.Text += "(q" + key + ")";
                    resultLabel.Text = "Не принадлежит";
                    return;
                }
                string value = dic[key];
                if (value.Equals("f,*"))
                {
                    resultLabel.Text = "Принадлежит";
                    showResultTextBox.Text += "(q" + key + ") -> (q" + value + ")";
                    return;
                }
                var temp = value.Split(",");
                currentState = temp[0];
                if(temp[1].Length == 2)
                {
                    st.Push(temp[1].Substring(0,1));
                }
                if(temp[1].Equals("*"))
                {
                    st.Pop();
                }
                showResultTextBox.Text += "(q" + key + ") -> (q" + value + ") |-- ";
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            dic.Clear();
            tableTranslationsListBox.Items.Clear();
        }

        private void loadMachineStateButton_Click(object sender, EventArgs e)
        {
            defaultMachineLoader();
        }

        private void defaultMachineLoader()
        {
            dic.Clear();
            dic.Add("0,a,Z", "0,aZ");
            dic.Add("0,a,a", "0,aa");
            dic.Add("0,b,a", "0,a");
            dic.Add("0,c,a", "1,a");
            dic.Add("1,c,a", "2,*");
            dic.Add("2,c,a", "1,a");
            dic.Add("2,*,Z", "f,*");
            dic.Add("1,*,Z", "3,*");
            tableTranslationsListBox.Items.Clear();
            tableTranslationsListBox.Items.Add("(q0,a,Z)  - > ( q0,aZ)");
            tableTranslationsListBox.Items.Add("(q0,a,a)  - > ( q0,aa)");
            tableTranslationsListBox.Items.Add("(q0,b,a)  - > ( q0,a)");
            tableTranslationsListBox.Items.Add("(q0,c,a)  - > ( q1,a)");
            tableTranslationsListBox.Items.Add("(q1,c,a)  - > ( q2,*)");
            tableTranslationsListBox.Items.Add("(q2,c,a)  - > ( q1,a)");
            tableTranslationsListBox.Items.Add("(q2,*,Z)  - > ( qf,*)");
            tableTranslationsListBox.Items.Add("(q1,*,Z)  - > ( q3,*)");
        }
    }
}