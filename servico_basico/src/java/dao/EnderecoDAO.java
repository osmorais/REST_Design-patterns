/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package dao;

import dao.iface.IntEnderecoDAO;
import java.sql.Connection;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.sql.Statement;
import java.util.ArrayList;
import modelo.Endereco;
import util.ConnectionFactory;

/**
 *
 * @author osmar
 */
public class EnderecoDAO implements IntEnderecoDAO {

    private final String INSERT = "INSERT INTO ENDERECO"
            + "(cep,logradouro,numero,complemento,bairro,"
            + "localidade,uf,pessoa)"
            + "VALUES (?,?,?,?,?,?,?,?);";
    
    private Connection conexao;

    @Override
    public Endereco cadastrar(Endereco endereco) {
        try {
            ConnectionFactory con = new ConnectionFactory();
            conexao = con.getConnection();

            PreparedStatement stmt = conexao.prepareStatement(INSERT,
                    Statement.RETURN_GENERATED_KEYS);
            stmt.setString(1, endereco.getCep());
            stmt.setString(2, endereco.getLogradouro());
            stmt.setString(3, endereco.getNumero());
            stmt.setString(4, endereco.getComplemento());
            stmt.setString(5, endereco.getBairro());
            stmt.setString(6, endereco.getLocalidade());
            stmt.setString(7, endereco.getUf());
            stmt.setInt(8, endereco.getFkPessoa());

            int lastId = 0;
            
            stmt.execute();
            final ResultSet rs = stmt.getGeneratedKeys();
            if (rs.next()) {
                lastId = rs.getInt(1);
            }
            
            endereco.setId(lastId);
            ConnectionFactory.closeConnection(conexao, stmt);
            
            return endereco;
        } catch (SQLException ex) {
            throw new RuntimeException("Erro: ", ex);
        }
    }
}
