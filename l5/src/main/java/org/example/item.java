package org.example;

public class item{
    int value;
    int n;
    int weight;
    float ratio;

    public item(int n, int value, int weight){
        this.value = value;
        this.n = n;
        this.weight = weight;
        this.ratio = (float)value / (float)weight;
    }

    @Override
    public String toString() {
        return "Wartość: " + value + ", Waga: " + weight + ", Numer: " + n + ", Ratio: " + ratio;
    }
}


