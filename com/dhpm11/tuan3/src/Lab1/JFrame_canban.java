/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package Lab1;

import java.awt.Color;
import javax.swing.JFrame;

/**
 *
 * @author Admin
 */
public class JFrame_canban extends JFrame{
    public JFrame_canban(){
        super("sss");
        setBackground(Color.RED);
        setSize(300,300);
        setDefaultCloseOperation(EXIT_ON_CLOSE);
        setLocationRelativeTo(null);
        setVisible(true);
    }
    public static void main(String[] args) {
        new JFrame_canban();
    }
}
