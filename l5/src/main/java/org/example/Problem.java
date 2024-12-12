package org.example;

import java.util.*;


public class Problem {
    int seed;
    int items_count;
    int min;
    int max;
    List<item> items = new ArrayList<item>();
    Random rand = new Random(seed);

    public Problem(int min, int max, int items_count, int seed){
        this.min = min;
        this.max = max;
        this.items_count = items_count;
        this.seed = seed;

        for(int i = 0; i < items_count; i++){
            items.add(new item(i, rand.nextInt(min,max), rand.nextInt(min,max)));
        }
    }

    public Result solve(int capacity){
        Result r1 = new Result();

        items.sort(new Comparator<item>() {
            @Override
            public int compare(item o1, item o2) {
                return Float.compare(o2.ratio, o1.ratio);
            }
        });


        for(item i : items){
            while (r1.total_weight + i.weight <= capacity){
                r1.add_item(i);
            }
        }

        return r1;
    }

    public void print_items(){
        for(item i : items){
            System.out.println(i.toString());
        }
    }

    @Override
    public String toString() {
        String str = "";
        for(item i : items){
            str += i.toString() + '\n';
        }

        return str;
    }
}
