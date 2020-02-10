/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package dao.iface;

import java.util.ArrayList;
import modelo.Departamento;

/**
 *
 * @author superalunocmc
 */
public interface IntDepartamentoDAO {
    
    public ArrayList<Departamento> listar();
    
    public Departamento cadastrar(Departamento departamento);
}
