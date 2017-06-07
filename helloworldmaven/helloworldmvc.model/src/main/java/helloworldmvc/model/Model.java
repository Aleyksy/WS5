package helloworldmvc.model;

import helloworldmvc.Contract.IModel;

public class Model implements IModel{
	
	  public String getHelloWorld() {
	        return DaoHelloworld.getinstance().getHelloWorldMessage();
	    }

	}