package org.example;

import com.fasterxml.jackson.databind.ObjectMapper;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.net.HttpURLConnection;
import java.net.URL;
import java.util.Objects;

public class API {
    String api_address;

    public Response search (String query) throws IOException {
        URL url = new URL(api_address);
        if(!Objects.equals(query, "")){
            url = new URL(this.api_address + "+" + query);
        }

        HttpURLConnection con = (HttpURLConnection) url.openConnection();
        con.setRequestMethod("GET");
        con.setRequestProperty("Content-Type", "application/json");
        con.setConnectTimeout(5000);
        con.setReadTimeout(5000);

        int status = con.getResponseCode();
        BufferedReader in = new BufferedReader(
                new InputStreamReader(con.getInputStream()));
        String inputLine;
        StringBuilder content = new StringBuilder();
        while ((inputLine = in.readLine()) != null) {
            content.append(inputLine);
        }
        in.close();

        //System.out.println(content);
        con.disconnect();
        String jsonString = content.toString();

        ObjectMapper objectMapper = new ObjectMapper();
        return objectMapper.readValue(jsonString, Response.class);
    }

    public API(String api_address) {
        this.api_address = api_address;
    }
}
