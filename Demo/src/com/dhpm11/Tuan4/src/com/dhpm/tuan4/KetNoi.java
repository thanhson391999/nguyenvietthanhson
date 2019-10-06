/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package com.dhpm.tuan4;

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
            conn=DriverManager.getConnection("jdbc:sqlserver://localhost:1433;databasename=BooksSuppliers;username=sa;password=123");
        } catch (Exception e) {
            e.printStackTrace();
        }
    }
    public boolean addData(LuuGiaTri L){
        String sql = "INSERT INTO Books VALUES(?,?,?,?,?,?)";
        try {
             PreparedStatement ps = conn.prepareStatement(sql);
             ps.setString(1, L.getName());
             ps.setString(2, L.getType());
             ps.setString(3, L.getAddress());
             ps.setString(4, L.getContact());
             ps.setString(5, L.getEmail());
             ps.setString(6, L.getRemarks());
             return ps.executeUpdate()> 0;
        } catch (Exception e) {
            e.printStackTrace();
        }
        return false;
}
    public boolean UpdateData(LuuGiaTri L){
        String sql = "Update Books set name=?,type=?,address=?,contact=?,email=?,remarks=? where ID=?";
        try {
            PreparedStatement ps = conn.prepareStatement(sql);
            ps.setString(1, L.getName());
            ps.setString(2, L.getType());
            ps.setString(3, L.getAddress());
            ps.setString(4, L.getContact());
            ps.setString(5, L.getEmail());
            ps.setString(6, L.getRemarks());
            ps.setString(7, L.getID());
            return ps.executeUpdate()>0;
        } catch (Exception e) {
            e.printStackTrace();
        }
        return false;
    }
    public boolean DeleteData(LuuGiaTri L){
        String sql = "Delete Books where ID=?";
        try {
            PreparedStatement ps = conn.prepareStatement(sql);
            ps.setString(1, L.getID());
            return ps.executeUpdate()>0;
        } catch (Exception e) {
            e.printStackTrace();
        }
        return false;
    }
    public ArrayList<LuuGiaTri> getListData(){
        ArrayList<LuuGiaTri> list = new ArrayList<>();
        String sql = "select *from Books";
        try {
            PreparedStatement ps = conn.prepareStatement(sql);
            ResultSet rs = ps.executeQuery();
            while(rs.next()){
                LuuGiaTri L = new LuuGiaTri();
                L.setID(rs.getString("ID"));
                L.setName(rs.getString("name"));
                L.setType(rs.getString("type"));
                L.setAddress(rs.getString("address"));
                L.setContact(rs.getString("contact"));
                L.setEmail(rs.getString("email"));
                L.setRemarks(rs.getString("remarks"));
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
