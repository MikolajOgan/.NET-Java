package org.example;

import java.util.ArrayList;
import java.util.List;

public class Result {
    int total_weight = 0;
    int total_value = 0;
    List<item> items = new ArrayList<item>();

    public void add_item(item item) {
        items.add(item);
        total_weight += item.weight;
        total_value += item.value;
    }

    @Override
    public String toString() {
        String str = "";

        str += "Total weight: " + total_weight + "\n" + "Total value: " + total_value + "\n";

        for (item i : items) {
            str += i.toString() + "\n";
        }

        return str;
    }
}
