package com.dhpm11.tuan2;

import java.awt.BorderLayout;
import java.awt.Color;
import java.awt.Font;

import javax.swing.JFrame;
import javax.swing.JLabel;
import javax.swing.JPanel;
import javax.swing.border.TitledBorder;

public class Bai4 extends JFrame{
	public Bai4() {
		setTitle("BorderLayout");
		setSize(300,300);
		setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		setLocationRelativeTo(null);
		getContentPane().setBackground(Color.BLACK);
		setVisible(true);
		JPanel pnBorder = new JPanel();
		pnBorder.setLayout(new BorderLayout());
		JPanel pnNorth = new JPanel();
		pnNorth.setBackground(Color.ORANGE);
		pnBorder.add(pnNorth,BorderLayout.NORTH);
		JLabel lblTitle=new JLabel("NORTH");
		pnNorth.add(lblTitle);
		Font ft=new Font("arial", Font.CENTER_BASELINE, 25);
		lblTitle.setFont(ft);
		JPanel pnSouth = new JPanel();
		JLabel lblTitle1=new JLabel("SOUTH");
		pnSouth.add(lblTitle1);
		Font ft1=new Font("arial", Font.BOLD, 25);
		lblTitle1.setFont(ft);
		pnSouth.setBackground(Color.BLUE);
		pnBorder.add(pnSouth,BorderLayout.SOUTH);
		JPanel pnWest = new JPanel();
		JLabel lblTitle2=new JLabel("WEST");
		pnWest.add(lblTitle2);
		Font ft2=new Font("arial", Font.BOLD, 25);
		lblTitle2.setFont(ft);
		pnWest.setBackground(Color.CYAN);
		pnBorder.add(pnWest,BorderLayout.WEST);
		JPanel pnEast = new JPanel();
		JLabel lblTitle3=new JLabel("EAST");
		pnEast.add(lblTitle3);
		Font ft3=new Font("arial", Font.BOLD, 25);
		lblTitle3.setFont(ft);
		pnEast.setBackground(Color.GREEN);
		pnBorder.add(pnEast,BorderLayout.EAST);
		JPanel pnCenter = new JPanel();
		JLabel lblTitle4=new JLabel("CENTER");
		pnCenter.add(lblTitle4);
		Font ft4=new Font("arial", Font.BOLD, 25);
		lblTitle4.setFont(ft);
		pnCenter.setBackground(Color.MAGENTA);
		pnBorder.add(pnCenter,BorderLayout.CENTER);
		getContentPane().add(pnBorder);
	}

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		new Bai4();
	}

}
