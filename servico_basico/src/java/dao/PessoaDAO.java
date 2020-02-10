/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package dao;

import dao.iface.IntPessoaDAO;
import java.sql.Connection;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.sql.Statement;
import modelo.Pessoa;
import util.ConnectionFactory;

/**
 *
 * @author superalunocmc
 */
public class PessoaDAO implements IntPessoaDAO {

    private static final String INSERT = "INSERT INTO PESSOA (nome,sexo)"
            + "VALUES (?,?);";

    private Connection conexao;

    @Override
    public void cadastrar(Pessoa pessoa) {
        try {
            ConnectionFactory con = new ConnectionFactory();
            conexao = con.getConnection();

            PreparedStatement stmt = conexao.prepareStatement(INSERT,
                    Statement.RETURN_GENERATED_KEYS);
            stmt.setString(1, pessoa.getNome());
            stmt.setInt(2, pessoa.getSexo().getId());

            int lastId = 0;

            stmt.execute();
            final ResultSet rs = stmt.getGeneratedKeys();
            if (rs.next()) {
                lastId = rs.getInt(1);
            }

            pessoa.setId(lastId);
            ConnectionFactory.closeConnection(conexao, stmt);
        } catch (SQLException ex) {
            throw new RuntimeException("Erro: ", ex);
        }
    }
}
