/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package servico;

import dao.DepartamentoDAO;
import dao.iface.IntDepartamentoDAO;
import java.util.ArrayList;
import modelo.Departamento;

/**
 *
 * @author superalunocmc
 */
public class SrvcDepartamento {
    
    public static ArrayList<Departamento> listar(){
        
        ArrayList<Departamento> arrdepartamento = new ArrayList<Departamento>();
        IntDepartamentoDAO objdepartamentodao = new DepartamentoDAO();
        
        return objdepartamentodao.listar();
    }
    
    public static Departamento cadastrar(Departamento departamento){

        IntDepartamentoDAO objdepartamentodao = new DepartamentoDAO();
        departamento = objdepartamentodao.cadastrar(departamento);
        
        return departamento;
    }
}
