#define a
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
namespace 二十四点猜解 {
	public partial class Form1 : Form {
		public Form1() {
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e) {
			int i = yunsuan(5, 3, 3);
#if a
			caiquanjie(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text), Convert.ToInt32(textBox3.Text), Convert.ToInt32(textBox4.Text));
#else
			try {
				if(caijie(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text), Convert.ToInt32(textBox3.Text), Convert.ToInt32(textBox4.Text))==true){
					MessageBox.Show("可以通过加减乘除算出24");
				}else{
					MessageBox.Show("不可以通过加减乘除算出24");
				}
			}catch(Exception){
				MessageBox.Show("请输入四个数字，程序将计算加减乘除是否可以得到24");
			}
#endif
		}
		private bool caijie(int a, int b, int c, int d) {
			int[] num = new int[] { a, b, c, d };
			for (int i = 0; i < 4; i++) {
				for (int j = 0; j < 4; j++) {
					if (j != i) {
						for (int k = 0; k < 4; k++) {
							if (k != i && k != j) {
								for (int l = 0; l < 4; l++) {
									if (l != i && l != j && l != k) {
										for (int m = 0; m < 4; m++) {
											int z = yunsuan(num[i],num[j],m);
											if (z != -1) {
												for (int n = 0; n < 4; n++) {
													int y = yunsuan(z, num[k], n);
													if (y != -1) {
														for (int o = 0; o < 4; o++) {
															int x = yunsuan(y, num[l], o);
															if (x == 24) {
																return true;
															}
															x = yunsuan(num[l], y, o);
															if (x == 24) {
																return true;
															}
														}
													}
													y = yunsuan(num[k],z, n);
													if (y != -1) {
														for (int o = 0; o < 4; o++) {
															int x = yunsuan(y, num[l], o);
															if (x == 24) {
																return true;
															}
															x = yunsuan(num[l], y, o);
															if (x == 24) {
																return true;
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
			}
			return false;
		}
		private int yunsuan(int a, int b, int c) {
			if (c == 0) {
				return a + b;
			}
			if (c == 1) {
				int d = a - b;
				return d < 0 ? -1 : d;
				
			}
			if (c == 2) {
				return a * b;
			}
			if (c == 3 &&b!=0) {
				int d = a / b;
				return a % b != 0 ? -1 : d;
			}
			return -1;
		}
		private bool caiquanjie(int a, int b, int c, int d) {
			int[] num = new int[] { a, b, c, d };
			for (int i = 0; i < 4; i++) {
				for (int j = 0; j < 4; j++) {
					if (j != i) {
						for (int k = 0; k < 4; k++) {
							if (k != i && k != j) {
								for (int l = 0; l < 4; l++) {
									if (l != i && l != j && l != k) {
										for (int m = 0; m < 4; m++) {
											int z = yunsuan(num[i], num[j], m);
											if (z != -1) {
												for (int n = 0; n < 4; n++) {
													int y = yunsuan(z, num[k], n);
													if (y != -1) {
														y = yunsuan(num[k], z, n);
														if (y != -1) {
															string str = "((" + num[i].ToString() + yunsuanfu(m) + num[j].ToString() + ")" + yunsuanfu(n) + num[k].ToString() + ")";
															if (doublecompute(y, num[l], ref str)) {
																textBox5.Text += str + "\r\n";
															}
														}
													}
													if ((n & 1) == 1) {
														y = yunsuan(num[k], z, n);
														if (y != -1) {
															string str = "(" + num[k].ToString() + yunsuanfu(n) + "(" + num[i].ToString() + yunsuanfu(m) + num[j].ToString() + ")" + ")"  ;
															if (doublecompute(y, num[l], ref str)) {
																textBox5.Text += str + "\r\n";
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
			}
			return false;
		}
		private bool doublecompute(int y, int z,ref string str) {
			for (int o = 0; o < 4; o++) {
				int x = yunsuan(y, z, o);
				if (x == 24) {
					str += yunsuanfu(o) + z.ToString();
					return true;
				}
				if ((o & 1) == 1) {
					x = yunsuan(z, y, o);
					if (x == 24) {
						str = z.ToString() + yunsuanfu(o)+str;
						return true;
					}
				}
			}
			return false;
		}
		private string yunsuanfu(int c) {
			if (c == 0) {
				return "+";
			}
			if (c == 1) {
				return "-";
			}
			if (c == 2) {
				return "*";
			}
			if (c == 3) {
				return "/";
			}
			return "";
		}
	}
}