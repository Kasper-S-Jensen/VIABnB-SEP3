package dk.viabnb.sep3.group6.dataserver.rest.t3.controllers;

import dk.viabnb.sep3.group6.dataserver.rest.t3.dao.administration.AdministrationDAO;
import dk.viabnb.sep3.group6.dataserver.rest.t3.models.Administrator;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.http.HttpStatus;
import org.springframework.http.ResponseEntity;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.PathVariable;
import org.springframework.web.bind.annotation.RestController;

import java.util.List;

@RestController public class AdministrationController
{
  private AdministrationDAO administrationDAO;

  @Autowired public AdministrationController(
      AdministrationDAO administrationDAO)
  {
    this.administrationDAO = administrationDAO;
  }

  @GetMapping("/admin/{email}") public ResponseEntity<Administrator> getAdminByEmail(
      @PathVariable String email)
  {
    Administrator adminToReturn = administrationDAO.getAdministratorByEmail(
        email);
    try
    {
      return new ResponseEntity<>(adminToReturn, HttpStatus.OK);
    }
    catch (Exception e)
    {
      return ResponseEntity.internalServerError().build();
    }
  }

  @GetMapping("/admins") public ResponseEntity<List<Administrator>> getAllAdmins()
  {
    List<Administrator> administratorListToReturn = administrationDAO.getAllAdministrators();
    try
    {
      if (administratorListToReturn == null)
      {
        return ResponseEntity.internalServerError().build();
      }
      return new ResponseEntity<>(administratorListToReturn, HttpStatus.OK);
    }
    catch (Exception e)
    {
      return ResponseEntity.internalServerError().build();
    }
  }
}
