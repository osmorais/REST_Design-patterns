/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package servico;

import dao.ClienteDAO;
import dao.EnderecoDAO;
import dao.iface.IntClienteDAO;
import dao.iface.IntEnderecoDAO;
import java.util.ArrayList;
import modelo.Cliente;
import modelo.Endereco;

/**
 *
 * @author superalunocmc
 */
public class SrvcCliente {
    
    public static Cliente cadastrar(Cliente cliente){
        
        ArrayList<Endereco> arrenderecos = new ArrayList<Endereco>();

        IntClienteDAO objpessoadao = new ClienteDAO();
        IntEnderecoDAO objenderecodao = new EnderecoDAO();

        cliente.setCodigoCliente("abc");
        cliente = objpessoadao.cadastrar(cliente);
        arrenderecos = cliente.getEnderecos();
        for (Endereco objendereco : arrenderecos) {
            objendereco.setFkPessoa(cliente.getFkPessoa());
            objendereco = objenderecodao.cadastrar(objendereco);
        }

        return cliente;
    }
}
