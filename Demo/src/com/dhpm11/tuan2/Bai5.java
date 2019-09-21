package com.dhpm11.tuan2;

import java.awt.BorderLayout;
import java.awt.Color;
import java.awt.Font;

import java.awt.*;
import java.awt.event.*;
import javax.swing.*;
import javax.swing.border.*;


import javax.swing.BoxLayout;
import javax.swing.JButton;
import javax.swing.JFrame;
import javax.swing.JLabel;
import javax.swing.JPanel;

public class Bai5 extends JFrame {
	public Bai5() {

		setSize(400,300);
		setLocationRelativeTo(null);
		setDefaultCloseOperation(EXIT_ON_CLOSE);
		//setResizable(false);
		setVisible(true);
		
		JPanel pnBorder = new JPanel();
		pnBorder.setLayout(new BorderLayout());
		JPanel pnNorth=new JPanel();
		JLabel lblTitle=new JLabel("Giải PT Bậc 2");
		pnNorth.add(lblTitle);
		pnBorder.add(pnNorth,BorderLayout.NORTH);
		lblTitle.setForeground(Color.BLACK);
		pnNorth.setBackground(Color.GRAY);
		Font ft=new Font("arial", Font.BOLD, 25);
		lblTitle.setFont(ft);
		getContentPane().add(pnBorder);

		
		JPanel pnSouth = new JPanel();
		pnSouth.setLayout(new BoxLayout(pnSouth,BoxLayout.X_AXIS));
		JButton btnGiai=new JButton("Giải   ");
		JButton btnXoa=new JButton("Xóa trắng");
		JButton btnThoat=new JButton("Thoát");
		pnSouth.add(btnGiai);
		pnSouth.add(Box.createVerticalStrut(10));
		pnSouth.add(btnXoa);
		pnSouth.add(Box.createVerticalStrut(10));
		pnSouth.add(btnThoat);
		pnSouth.add(Box.createVerticalStrut(10));
		pnBorder.add(pnSouth,BorderLayout.SOUTH);
		Border  southborder=BorderFactory.createLineBorder(Color.BLUE);
		TitledBorder southTitleBorder=new TitledBorder(southborder, "Chọn Thao Tác");
		pnSouth.setBorder(southTitleBorder);
		
		JPanel pnCenter = new JPanel();
		pnCenter.setLayout(new BoxLayout(pnCenter,BoxLayout.Y_AXIS));
		pnBorder.add(pnCenter,BorderLayout.CENTER);
		JTextField txtSoa = new JTextField();
		JTextField txtSob = new JTextField();
		JTextField txtSoc = new JTextField();
		JTextField txtKetqua = new JTextField();
		Border  centerborder=BorderFactory.createLineBorder(Color.RED);
		TitledBorder centerTitleBorder=new TitledBorder(centerborder, "nhập a,b,c");
		pnCenter.setBorder(centerTitleBorder);
		
		JPanel pna=new JPanel();
		JLabel lbla=new JLabel("a:");
		final JTextField txta=new  JTextField(15);
		pna.add(lbla);
		pna.add(txta);
		pnCenter.add(pna);

		JPanel pnb=new JPanel();
		JLabel lblb=new JLabel("b:");
		final JTextField txtb=new  JTextField(15);
		pnb.add(lblb);
		pnb.add(txtb);
		pnCenter.add(pnb);
		
		JPanel pnc=new JPanel();
		JLabel lblc=new JLabel("c:");
		final JTextField txtc=new JTextField(15);
		pnc.add(lblc);
		pnc.add(txtc);
		pnCenter.add(pnc);
		
		JPanel pnketqua=new JPanel();
		JLabel lblketqua=new JLabel("Kết quả:");
		final JTextField txtketqua=new  JTextField(15);
		pnketqua.add(lblketqua);
		pnketqua.add(txtketqua);
		pnCenter.add(pnketqua);

		lbla.setPreferredSize(lblketqua.getPreferredSize());
		lblb.setPreferredSize(lblketqua.getPreferredSize());
		lblc.setPreferredSize(lblketqua.getPreferredSize());
		btnThoat.addActionListener(new ActionListener() {
			public void	actionPerformed(ActionEvent arg0) {
			int ret=JOptionPane.showConfirmDialog(null, "Muốn thoát hả?", "Thoát", JOptionPane.YES_NO_OPTION);
			if(ret==JOptionPane.YES_OPTION)
				System.exit(0);

			}
		});
		btnXoa.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent arg0) {
				txta.setText("");
				txtb.setText("");
				txtc.setText("");
				txtKetqua.setText("");
				txta.requestFocus();
			}
		});
		btnGiai.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent arg0) {
				float a,b,c;
				String sa=txta.getText();
				try
				{
					a=Float.parseFloat(sa);
				}
				catch(Exception ex)
				{
					JOptionPane.showMessageDialog(null, "Nhập sai định dạng!");
					txta.selectAll();
					txta.requestFocus();
					return;
				}
				String sb=txtb.getText();
				try
				{
					b=(float) Float.parseFloat(sb);
				}
				catch(Exception ex)
				{
					JOptionPane.showMessageDialog(null, "Nhập sai định dạng!");
					txtb.selectAll();
					txtb.requestFocus();
					return;
				}
				String sc=txtc.getText();
				try
				{
					c=(float)  Float.parseFloat(sc);
				}
				catch(Exception ex)
				{
					JOptionPane.showMessageDialog(null, "Nhập sai định dạng!");
					txtc.selectAll();
					txtc.requestFocus();
					return;
				}
				Double delta,nghiem,x,x1,x2;
				if (a == 0) {
					if (b == 0) {
						if (c == 0) 
							
							txtketqua.setText("phuong trinh vo so nghiem");
							
						else 
							
							txtketqua.setText("phuong trinh vo nghiem");
						
					} else {
						nghiem = (double) (-c / b);
						txtketqua.setText("x="+nghiem);
					}
				} else {
					delta = (Double) (Math.pow(b, 2) -( 4 * a * c));
					if (delta < 0)
						{
						txtketqua.setText("phuong trinh vo nghiem");
						}
					else if (delta == 0) {
						x = (double) (-b / (2 * a));
						
						txtketqua.setText("x1=x2="+x);
					} else {
						System.out.println("phuong trinh co 2 nghiem phan biet:");
						x1 = (Double) ((-b + Math.sqrt(delta)) / (2 * a));
	
						x2 = (Double) ((-b - Math.sqrt(delta)) / (2 * a));
						
						txtketqua.setText("x1="+x1+" && "+"x2="+x2);
					}				
				}
			}

			});
		

	}

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		new Bai5();
	}

}
