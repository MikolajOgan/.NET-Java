package org.example;

import com.fasterxml.jackson.annotation.JsonIgnoreProperties;

import java.util.List;

@JsonIgnoreProperties(ignoreUnknown = true)
class Response {
    public int total;
    public int totalHits;
    public List<Hit> hits;

}
