package dk.viabnb.sep3.group6.dataserver.rest.t3.models;

public class HostRegistrationRequest
{
  private int id;
  private String personalImage;
  private String cprNumber;
  private RequestStatus status = RequestStatus.NotAnswered;
  private Host host;

  public HostRegistrationRequest(int id, String personalImage, String cprNumber,
      RequestStatus status, Host host)
  {
    this.id = id;
    this.personalImage = personalImage;
    this.cprNumber = cprNumber;
    this.status = status;
    this.host = host;
  }

  public int getId()
  {
    return id;
  }

  public void setId(int id)
  {
    this.id = id;
  }

  public String getPersonalImage()
  {
    return personalImage;
  }

  public void setPersonalImage(String personalImage)
  {
    this.personalImage = personalImage;
  }

  public String getCprNumber()
  {
    return cprNumber;
  }

  public void setCprNumber(String cprNumber)
  {
    this.cprNumber = cprNumber;
  }

  public RequestStatus getStatus()
  {
    return status;
  }

  public void setStatus(RequestStatus status)
  {
    this.status = status;
  }

  public Host getHost() {
    return host;
  }

  public void setHost(Host host) {
    this.host = host;
  }
}
