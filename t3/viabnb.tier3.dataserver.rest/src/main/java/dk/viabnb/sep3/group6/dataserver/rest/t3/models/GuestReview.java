package dk.viabnb.sep3.group6.dataserver.rest.t3.models;

import java.time.LocalDate;

public class GuestReview
{
  private int id;
  private double rating;
  private String text;
  private String hostEmail;
  private LocalDate createdDate;

  public GuestReview(int id, double rating, String text, String hostEmail, LocalDate createdDate)
  {
    this.id = id;
    this.rating = rating;
    this.text = text;
    this.hostEmail = hostEmail;
    this.createdDate = createdDate;
  }

  public int getId()
  {
    return id;
  }

  public void setId(int id)
  {
    this.id = id;
  }

  public double getRating()
  {
    return rating;
  }

  public void setRating(double rating)
  {
    this.rating = rating;
  }

  public String getText()
  {
    return text;
  }

  public void setText(String text)
  {
    this.text = text;
  }

  public String getHostEmail()
  {
    return hostEmail;
  }

  public void setHostEmail(String hostEmail)
  {
    this.hostEmail = hostEmail;
  }

  public LocalDate getCreatedDate() {
    return createdDate;
  }

  public void setCreatedDate(LocalDate createdDate) {
    this.createdDate = createdDate;
  }
}
