/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package dao;

import dao.iface.IntClienteDAO;
import java.sql.Connection;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.sql.Statement;
import modelo.Cliente;
import util.ConnectionFactory;

/**
 *
 * @author osmar
 */
public class ClienteDAO implements IntClienteDAO {

    private static final String INSERT_CLIENTE = "INSERT INTO CLIENTE ("
            + "codigocliente, pessoa)"
            + "VALUES (?,?);";

    private Connection conexao;

    @Override
    public Cliente cadastrar(Cliente cliente) {
        try {
            ConnectionFactory con = new ConnectionFactory();
            conexao = con.getConnection();
            
            PessoaDAO pessoadao = new PessoaDAO();
            pessoadao.cadastrar(cliente);
            cliente.setFkPessoa(cliente.getId());

            PreparedStatement stmt = conexao.prepareStatement(INSERT_CLIENTE,
                    Statement.RETURN_GENERATED_KEYS);
            stmt.setString(1, cliente.getCodigoCliente());
            stmt.setInt(2, cliente.getFkPessoa());

            int lastId = 0;

            stmt.execute();
            final ResultSet rs = stmt.getGeneratedKeys();
            if (rs.next()) {
                lastId = rs.getInt(1);
            }

            cliente.setId(lastId);
            ConnectionFactory.closeConnection(conexao, stmt);
            return cliente;
        } catch (SQLException ex) {
            throw new RuntimeException("Erro: ", ex);
        }
    }
}
