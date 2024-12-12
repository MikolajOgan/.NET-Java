package org.example;

import org.junit.jupiter.api.Test;

import static org.junit.jupiter.api.Assertions.*;

class ProblemTest {

    @Test
            public void NumberCountTest(){
                Problem p1 = new Problem(1, 10, 10, 123);

                assertEquals(p1.items.size(), 10);
            }

    @Test
    public void CorrectItems(){
        Problem p1 = new Problem(1, 10, 10, 123);
        Result r1 = p1.solve(10);
        int weight = 0;
        int value = 0;
        for(item i : r1.items){
            weight += i.weight;
            value += i.value;
        }

        assertEquals(weight, r1.total_weight);
        assertEquals(value, r1.total_value);
    }

    @Test
    public void WeightCorrect(){
        Problem p1 = new Problem(1, 10, 10, 123);
        int capacity = 10;
        Result r1 = p1.solve(capacity);

        assertTrue(r1.total_weight <= capacity);
    }

    @Test
    public void BackpackEmpty(){
        Problem p1 = new Problem(8, 10, 10, 123);
        int capacity = 2;
        Result r1 = p1.solve(capacity);

        assertTrue(r1.items.isEmpty());
    }

    @Test
    public void AtLeastOne(){
        Problem p1 = new Problem(1, 10, 10, 123);
        int capacity = 10;
        Result r1 = p1.solve(capacity);

        Boolean notToHeavy = false;

        for(item i : p1.items){
            if(i.weight < capacity){
                notToHeavy = true;
            }
        }

        assertEquals(!r1.items.isEmpty(), notToHeavy);
    }
}