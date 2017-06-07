package helloworldmvc.model;

import java.io.IOException;
import java.io.InputStream;

public class DaoHelloworld {
	private String FileName = "HelloWorld.txt";
	private String helloWorldMessage = null;
	private static DaoHelloworld instance = null;
	
	public String getHelloWorldMessage(){
		return helloWorldMessage;
	}

	public void setHelloWorldMessage(String helloWorldMessage) {
		this.helloWorldMessage = helloWorldMessage;
	}
	
	 private DaoHelloworld(){
	        readFile();
	    }

	    public static DaoHelloworld getinstance(){
	        if (instance == null)
	            instance = new DaoHelloworld();
	        return instance;
	    }
	    private void readFile(){
	        try(InputStream is= this.getClass().getResourceAsStream("/"+FileName)){
	            int c;
	            helloWorldMessage = "";
	            do{
	                c = is.read();
	                if (c != -1)
	                    helloWorldMessage +=(char)c;

	            }while(c != -1);

	        } catch (IOException e) {
	            e.printStackTrace();
	        }
	    }


	}