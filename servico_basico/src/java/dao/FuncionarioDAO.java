/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package dao;

import dao.iface.IntFuncionarioDAO;
import java.sql.Connection;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.sql.Statement;
import modelo.Funcionario;
import util.ConnectionFactory;

/**
 *
 * @author superalunocmc
 */
public class FuncionarioDAO implements IntFuncionarioDAO {

    private static final String INSERT = "INSERT INTO FUNCIONARIO ("
            + "departamento,pessoa)"
            + "VALUES (?,?);";

    private Connection conexao;

    @Override
    public Funcionario cadastrar(Funcionario funcionario) {
        try {
            ConnectionFactory con = new ConnectionFactory();
            conexao = con.getConnection();
            
            PessoaDAO pessoadao = new PessoaDAO();
            pessoadao.cadastrar(funcionario);
            funcionario.setFkPessoa(funcionario.getId());

            PreparedStatement stmt = conexao.prepareStatement(INSERT,
                    Statement.RETURN_GENERATED_KEYS);
            stmt.setInt(1, funcionario.getDepartamento().getId());
            stmt.setInt(2, funcionario.getFkPessoa());

            int lastId = 0;

            stmt.execute();
            final ResultSet rs = stmt.getGeneratedKeys();
            if (rs.next()) {
                lastId = rs.getInt(1);
            }

            funcionario.setId(lastId);
            ConnectionFactory.closeConnection(conexao, stmt);
            return funcionario;
        } catch (SQLException ex) {
            throw new RuntimeException("Erro: ", ex);
        }
    }
}
