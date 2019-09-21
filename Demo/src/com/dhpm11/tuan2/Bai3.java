package com.dhpm11.tuan2;

import java.awt.Color;
import java.awt.Font;

import javax.swing.BoxLayout;
import javax.swing.JButton;
import javax.swing.JFrame;
import javax.swing.JPanel;



public class Bai3 extends JFrame {
	public Bai3() {
		setTitle("DemoBoxLayout");
		setVisible(true);
		setSize(600,300);
		setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		setLocationRelativeTo(null);
		getContentPane().setBackground(Color.yellow);
		JPanel pnBox=new JPanel ();
		pnBox.setLayout(new BoxLayout(pnBox, BoxLayout.Y_AXIS));//theo chieu tu tren xuong
		//pnBox.setLayout(new BoxLayout(pnBox, BoxLayout.Y_AXIS));//theo chieu tu trai qua phai
		JButton btn1 = new JButton("BoxLayout");
		btn1.setForeground(Color.RED);
		Font font=new Font("Arial",Font.BOLD / Font.ITALIC,25);
		btn1.setFont(font);pnBox.add(btn1);
		JButton btn2 = new JButton("X_AXIS");
		btn2.setForeground(Color.BLUE);
		btn2.setFont(font);pnBox.add(btn2);
		JButton btn3 = new JButton("Y_AXIS");
		btn3.setForeground(Color.ORANGE);
		btn3.setFont(font);pnBox.add(btn3);
		java.awt.Container con =  getContentPane();
		con.add(pnBox);
		}

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		new Bai3();
	}
 
}
