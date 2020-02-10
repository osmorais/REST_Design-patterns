/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package dao;

import dao.iface.IntDepartamentoDAO;
import java.sql.Connection;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.sql.Statement;
import java.util.ArrayList;
import modelo.Departamento;
import util.ConnectionFactory;

/**
 *
 * @author superalunocmc
 */
public class DepartamentoDAO implements IntDepartamentoDAO {

    private final String SELECT_ALL = "SELECT * FROM DEPARTAMENTO;";
    private static final String INSERT = "INSERT INTO DEPARTAMENTO (descricao)"
            + "VALUES (?);";

    private Connection conexao;

    @Override
    public ArrayList<Departamento> listar() {
        try {
            ArrayList<Departamento> arrdepartamento = new ArrayList<Departamento>();
            ConnectionFactory con = new ConnectionFactory();

            conexao = con.getConnection();
            PreparedStatement stmt = conexao.prepareStatement(SELECT_ALL);

            ResultSet rs = stmt.executeQuery();
            while (rs.next()) {
                Departamento objdepartamento = new Departamento();
                objdepartamento.setId(rs.getInt("id"));
                objdepartamento.setDescricao(rs.getString("descricao"));
                arrdepartamento.add(objdepartamento);
            }

            return arrdepartamento;
        } catch (SQLException ex) {
            throw new RuntimeException("Erro: ", ex);
        }
    }

    @Override
    public Departamento cadastrar(Departamento departamento) {
        try {
            ConnectionFactory con = new ConnectionFactory();
            conexao = con.getConnection();

            PreparedStatement stmt = conexao.prepareStatement(INSERT,
                    Statement.RETURN_GENERATED_KEYS);
            stmt.setString(1, departamento.getDescricao());

            int lastId = 0;

            stmt.execute();
            final ResultSet rs = stmt.getGeneratedKeys();
            if (rs.next()) {
                lastId = rs.getInt(1);
            }

            departamento.setId(lastId);
            ConnectionFactory.closeConnection(conexao, stmt);
            return departamento;
        } catch (SQLException ex) {
            throw new RuntimeException("Erro: ", ex);
        }
    }
}
