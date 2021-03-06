package dk.viabnb.sep3.group6.dataserver.rest.t3.controllers;

import dk.viabnb.sep3.group6.dataserver.rest.t3.dao.guest.GuestDAO;
import dk.viabnb.sep3.group6.dataserver.rest.t3.dao.rentrequest.RentRequestDAO;
import dk.viabnb.sep3.group6.dataserver.rest.t3.models.Guest;
import org.junit.jupiter.api.BeforeEach;
import org.junit.jupiter.api.Test;
import org.springframework.http.ResponseEntity;

import java.util.ArrayList;

import static org.junit.jupiter.api.Assertions.assertEquals;
import static org.mockito.Mockito.mock;
import static org.mockito.Mockito.when;

class GuestControllerTest
{

  private GuestDAO guestDAO;
  private GuestController controller;
  private Guest guest;
  private RentRequestDAO rentRequestDAO;

  @BeforeEach void setup()
  {
    guestDAO = mock(GuestDAO.class);
    rentRequestDAO = mock(RentRequestDAO.class);
    controller = new GuestController(guestDAO, rentRequestDAO);
    guest = new Guest(1, "test@test.com", "test", "test", "test", "+4588888888",
        null, new ArrayList<>(), "111111-1111", true, 293886, new ArrayList<>(),
        true);

  }

  @Test public void createANullGuestReturnsBadRequestTest()
  {
    Guest guest = null;
    assertEquals(ResponseEntity.internalServerError().build(),
        controller.createGuest(guest));
  }

  @Test public void failureOnCreateGuestReturnsInternalServerErrorTest()
  {
    when(guestDAO.createGuest(guest)).thenReturn(null);
    assertEquals(ResponseEntity.internalServerError().build(),
        controller.createGuest(guest));
  }

  @Test public void failureOnGettingAllGuestsReturnsInternalServerErrorTest()
  {
    when(guestDAO.getAllGuests()).thenThrow(IllegalStateException.class);
    assertEquals(ResponseEntity.internalServerError().build(),
        controller.getAllGuests(null, null, null));
  }

}