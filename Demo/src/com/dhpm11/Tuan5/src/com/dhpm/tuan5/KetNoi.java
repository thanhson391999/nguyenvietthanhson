/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package com.dhpm.tuan5;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.PreparedStatement;
import java.util.ArrayList;
import java.sql.ResultSet;
/**
 *
 * @author Admin
 */
public class KetNoi {
    private Connection conn ;
    public KetNoi(){
        try {
            Class.forName("com.microsoft.sqlserver.jdbc.SQLServerDriver");
            conn=DriverManager.getConnection("jdbc:sqlserver://localhost:1433;databasename=DBEMPLOYEE;username=sa;password=123");
        } catch (Exception e) {
            e.printStackTrace();
        }
    }
    public boolean addData(LuuGiaTri L){
        String sql = "INSERT INTO Employee VALUES(?,?,?,?,?)";
        try {
             PreparedStatement ps = conn.prepareStatement(sql);
             ps.setString(1, L.getName());
             ps.setString(2, L.getAddress());
             ps.setString(3, L.getGender());
             ps.setString(4, L.getKnowledge());
             ps.setString(5, L.getSubject());
             return ps.executeUpdate()> 0;
        } catch (Exception e) {
            e.printStackTrace();
        }
        return false;
}
    public ArrayList<LuuGiaTri> getListData(){
        ArrayList<LuuGiaTri> list = new ArrayList<>();
        String sql = "select *from Employee";
        try {
            PreparedStatement ps = conn.prepareStatement(sql);
            ResultSet rs = ps.executeQuery();
            while(rs.next()){
                LuuGiaTri L = new LuuGiaTri();  
                L.setName(rs.getString("name"));              
                L.setAddress(rs.getString("address"));
                L.setGender(rs.getString("gender"));
                L.setKnowledge(rs.getString("knowledge"));
                L.setSubject(rs.getString("subject"));
                list.add(L);
            }
            
            
        } catch (Exception e) {
            e.printStackTrace();
        }
        
        
        
        
        return list;
    }
   
    public static void main(String[] args) {
        new KetNoi();
    }
}
