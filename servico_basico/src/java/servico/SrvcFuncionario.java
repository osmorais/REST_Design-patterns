/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package servico;

import dao.EnderecoDAO;
import dao.FuncionarioDAO;
import dao.iface.IntEnderecoDAO;
import dao.iface.IntFuncionarioDAO;
import java.util.ArrayList;
import modelo.Endereco;
import modelo.Funcionario;

/**
 *
 * @author superalunocmc
 */
public class SrvcFuncionario {
    
    public static Funcionario cadastrar(Funcionario funcionario){
        
        ArrayList<Endereco> arrenderecos = new ArrayList<Endereco>();

        IntFuncionarioDAO objpessoadao = new FuncionarioDAO();
        IntEnderecoDAO objenderecodao = new EnderecoDAO();

        funcionario = objpessoadao.cadastrar(funcionario);
        arrenderecos = funcionario.getEnderecos();
        for (Endereco objendereco : arrenderecos) {
            objendereco.setFkPessoa(funcionario.getFkPessoa());
            objendereco = objenderecodao.cadastrar(objendereco);
        }

        return funcionario;
    }
}
