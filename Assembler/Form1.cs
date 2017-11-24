using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;


namespace Assembler
{
	public partial class Form1: Form
	{
		
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)//Assembler
		{
			textBox2.Clear();
			textBox5.Clear();

			Data_GMC4[] a = new Data_GMC4[textBox1.Lines.Length];
			var rx = new Regex("^([A-Z][A-Z0-9]?[A-Z0-9]?[A-Z0-9]?[A-Z0-9]?[A-Z0-9]?[A-Z0-9]?[A-Z0-9]?)? +(KA|AO|CH|CY|AM|MA|M+|M-|START|RET|END|((TIA|AIA|TIY|AIY|CIA|CIY|DC) +[A-F0-9])|(CAL +(RSTO|SETR|RSTR|CMPL|CHNG|SIFT|ENDS|ERRS|SHTS|LONS|SUND|TIMR|DSPR|DEM-|DEM+))|(JUMP +[A-Z][A-Z0-9]?[A-Z0-9]?[A-Z0-9]?[A-Z0-9]?[A-Z0-9]?[A-Z0-9]?[A-Z0-9]?))( +;.*)?$", RegexOptions.Compiled);

			int str = -1;
			int ret = -1;
			int end = -1;

			int addr = 0;

			//input
			for(int i=0; i<textBox1.Lines.Length; i++)
			{
				a[i] = new Data_GMC4();
				string line = textBox1.Lines[i];

				if (rx.IsMatch(line)) {
					string[] word = line.Split(' ');
					string inst = word[1];

					if(inst == "START"){
						a[i].Add(word[0], word[1]);
						str = i;
					}else if(inst == "RET"){
						a[i].Add(word[0], word[1]);
						ret = i;
					}else if(inst == "END"){
						a[i].Add(word[0], word[1]);
						end = i;
					}else if(inst == "KA" || inst == "AO" || inst == "CH" || inst == "CY" || inst == "AM" || inst == "MA" || inst == "M+" || inst == "M-"){
						a[i].Add(word[0], word[1]);
						a[i].addres = addr;
						addr += 1;
					}else if(inst == "TIA" || inst == "AIA" || inst == "TIY" || inst == "AIY" || inst == "CIA" || inst == "CIY" || inst == "CAL"){
						a[i].Add(word[0], word[1], word[2]);
						a[i].addres = addr;
						addr += 2;
					}else if(inst == "JUMP"){
						a[i].Add(word[0], word[1], word[2]);
						a[i].addres = addr;
						addr += 3;
					}else if(inst == "DC"){
						a[i].Add(word[0], word[1], word[2]);
					}
				}else{
					//error
					textBox5.Text += "Syntax Error： 構文が間違ってます\r\n";
					textBox5.Text += i+1 + "行目" + line + "\r\n";
					return;
				}
			}
			//error
			if(str < 0){
				textBox5.Text += "Syntax Error： \"START\"がありません\r\n";
				return;
			}if(ret < 0){
				textBox5.Text += "Syntax Error： \"RET\"がありません\r\n";
				return;
			}if(end < 0){
				textBox5.Text += "Syntax Error： \"END\"がありません\r\n";
				return;
			}if(addr > 79){
				textBox5.Text += "Overflow： プログラムメモリが足りません\r\n";
				return;
			}

			//edit memory_program
			for(int i=str+1; i<ret; i++)
			{
				string inst = a[i].instruction;
				string code = null;
			
				if(inst == "KA"){
					code = "0";
				}else if(inst == "AO"){
					code = "1";
				}else if(inst == "CH"){
					code = "2";
				}else if(inst == "CY"){
					code = "3";
				}else if(inst == "AM"){
					code = "4";
				}else if(inst == "MA"){
					code = "5";
				}else if(inst == "M+"){
					code = "6";
				}else if(inst == "M-"){
					code = "7";
				}else if(inst == "TIA"){
					code = "8" + a[i].operand;
				}else if(inst == "AIA"){
					code = "9" + a[i].operand;
				}else if(inst == "TIY"){
					code = "A" + a[i].operand;
				}else if(inst == "AIY"){
					code = "B" + a[i].operand;
				}else if(inst == "CIA"){
					code = "C" + a[i].operand;
				}else if(inst == "CIY"){
					code = "D" + a[i].operand;
				}else if(inst == "CAL"){
					code = "E";
					string ope = a[i].operand; 
					if(ope == "RSTO"){
						code += "0";
					}else if(ope == "SETR"){
						code += "1";
					}else if(ope == "RSTR"){
						code += "2";
					}else if(ope == "CMPL"){
						code += "4";
					}else if(ope == "CHNG"){
						code += "5";
					}else if(ope == "SIFT"){
						code += "6";
					}else if(ope == "ENDS"){
						code += "7";
					}else if(ope == "ERRS"){
						code += "8";
					}else if(ope == "SHTS"){
						code += "9";
					}else if(ope == "LONS"){
						code += "A";
					}else if(ope == "SUND"){
						code += "B";
					}else if(ope == "TIMR"){
						code += "C";
					}else if(ope == "DSPR"){
						code += "D";
					}else if(ope == "DEM-"){
						code += "E";
					}else if(ope == "DEM+"){
						code += "F";
					}
				}else if(inst == "JUMP"){
					code = "F";
					string ope = a[i].operand;
					bool flag = true;
					for(int j=str+1; j<ret; j++)
					{
						if(ope == a[j].label){
							code += a[j].addres.ToString("X2");
							flag = false;
						}
					}
					if(flag){//error
						textBox5.Text += "Undefined： ラベル\""+ope+ "\"がありません\r\n";
						textBox2.Clear();
						return;
					}
				}
				textBox2.Text += code;
			}
			for(int i=addr; i<80; i++) textBox2.Text+=" ";

			textBox2.Text += ' ';//separate program and data 

			//edit memory_data
			for(int i=ret+1; i<end; i++)
			{
				if(i-ret > 16){
					textBox5.Text += "Overflow： データメモリが足りません\r\n";
					textBox2.Clear();
					return;
				}
				if(a[i].instruction == "DC"){
					textBox2.Text += a[i].operand;
					a[i].addres = 79 + i - ret;
				}
			}
			for(int i=0; i<16-(end-ret-1); i++) textBox2.Text+=" ";
			textBox5.Text += "Assembling Successful\r\n";

		}

		private void button2_Click(object sender, EventArgs e)//Open
		{
			if(openFileDialog1.ShowDialog() != DialogResult.OK) return;
			textBox5.Clear();
			textBox3.Text = Path.GetFileName(openFileDialog1.FileName);
			textBox4.Text = "assy_" + textBox3.Text;

			StreamReader sr = new StreamReader(openFileDialog1.FileName, Encoding.GetEncoding("shift_jis"));
			textBox1.Text = sr.ReadToEnd();
			sr.Close();
		}

		private void button3_Click(object sender, EventArgs e)//Save
		{
			if(textBox4.Text == ""){
				textBox5.Clear();
				textBox5.Text = "ファイルを開いていません\r\nファイルを指定してください\r\n";
				return;
			}

			StreamWriter sw_in = new StreamWriter(Path.GetDirectoryName(openFileDialog1.FileName) + '\\' + textBox3.Text, false, Encoding.GetEncoding("shift_jis"));
			for(int i=0; i<textBox1.Lines.Length-1; i++) sw_in.WriteLine(textBox1.Lines[i]);
			sw_in.Write(textBox1.Lines[textBox1.Lines.Length - 1]);
			sw_in.Close();

			StreamWriter sw_out = new StreamWriter(Path.GetDirectoryName(openFileDialog1.FileName) + '\\' + textBox4.Text, false, Encoding.GetEncoding("shift_jis"));
			sw_out.Write(textBox2.Lines[0]);
			sw_out.Close();

			textBox5.Clear();
			textBox5.Text += "Saving Successful\r\n";
		}
	}
}


class Data_GMC4
{
	public string label = null;
	public string instruction = null;
	public string operand = null;
	public int addres = -1;

	public Data_GMC4()
	{
	}

	public void Add(string lab, string inst, string ope)
	{
		label = lab;
		instruction = inst;
		operand = ope;
	}
	public void Add(string lab, string inst)
	{
		label = lab;
		instruction = inst;
		operand = null;
	}

};
