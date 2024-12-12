package org.example;

import org.junit.jupiter.api.Test;

import java.io.IOException;
import java.sql.SQLException;

import static org.junit.jupiter.api.Assertions.*;

class AppTest {
    @Test
    void testGetImageEmpty() throws IOException {
        App app = new App();
        assertNotEquals(app.get_image("").largeImageURL, "");
    }

    @Test
    void testNextImageIsDifferent() throws IOException {
        App app = new App();
        String im1 = app.get_image("").largeImageURL;
        String im2 = app.next_image("").largeImageURL;
        assertNotEquals(im1, im2);
    }

    @Test
    void testSearchQuery() throws IOException {
        App app = new App();
        String im1 = app.get_image("red+flying").largeImageURL;
        String im2 = app.get_image("white+sleeping").largeImageURL;
        assertNotEquals(im1,im2);
    }

    @Test
    void testFaveAddedCorrectly() throws SQLException, IOException {
        App app = new App();
        String im1 = app.get_image("red+flying").largeImageURL;
        app.fave_add();
        assertNotEquals(app.get_fav().largeImageURL, "");
    }

    @Test
    void testPreviousLessThenZeroProtection() throws SQLException, IOException {
        App app = new App();
        String im1 = app.get_image("").largeImageURL;
        String im2 = app.previous_image("").largeImageURL;
        assertTrue(app.current_hit >= 0);
    }

    @Test
    void testNotDuplicatedFavs() throws SQLException, IOException {
        App app = new App();
        String im1 = app.get_image("").largeImageURL;
        app.fave_add();
        assertFalse(app.fave_add());
    }
}