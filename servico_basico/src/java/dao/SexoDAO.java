/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package dao;

import dao.iface.IntSexoDAO;
import java.sql.Connection;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.util.ArrayList;
import modelo.Sexo;
import util.ConnectionFactory;

/**
 *
 * @author superalunocmc
 */
public class SexoDAO implements IntSexoDAO {

    private final String SELECT_ALL = "SELECT * FROM SEXO;";
    private Connection conexao;

    @Override
    public ArrayList<Sexo> listar() {
        
        try {
            ArrayList<Sexo> arrsexo = new ArrayList<Sexo>();
            ConnectionFactory con = new ConnectionFactory();

            conexao = con.getConnection();
            PreparedStatement stmt = conexao.prepareStatement(SELECT_ALL);

            ResultSet rs = stmt.executeQuery();
            while (rs.next()) {
                Sexo objsexo = new Sexo();
                objsexo.setId(rs.getInt("id"));
                objsexo.setDescricao(rs.getString("descricao"));
                arrsexo.add(objsexo);
            }

            return arrsexo;
        } catch (SQLException ex) {
            throw new RuntimeException("Erro: ", ex);
        }
    }
}
