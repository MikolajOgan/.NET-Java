package org.example;

import java.io.IOException;
import java.sql.*;
import java.util.ArrayList;
import java.util.List;
import java.util.Objects;


public class App {
    API API = new API("https://pixabay.com/api/?key=xxx&q=dragon+fantasy");
    Response resp = null;
    int current_hit = 0;
    String previous_query = null;
    int current_favorite = 0;
    List<Hit> favs = new ArrayList<>();

    public Hit get_image(String query) throws IOException {
        if(this.resp == null || !Objects.equals(query, this.previous_query)) {
            this.resp = API.search(query);
            this.current_hit = 0;
            this.previous_query = query;
        }
        return resp.hits.get(this.current_hit);
    }

    public Boolean fave_add() {
        if(resp != null) {


            String url = "jdbc:sqlite:identifier.sqlite"; // Database URL
            String sql = "INSERT INTO hits (id, pageURL, type, tags, previewURL, previewWidth, previewHeight, webformatURL, webformatWidth, webformatHeight, largeImageURL, imageWidth, imageHeight, imageSize, views, downloads, collections, likes, comments, user_id, user, userImageURL) VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?)";

            try (Connection conn = DriverManager.getConnection(url);
                 PreparedStatement pstmt = conn.prepareStatement(sql)) {

                pstmt.setInt(1, resp.hits.get(this.current_hit).id);
                pstmt.setString(2, resp.hits.get(this.current_hit).pageURL);
                pstmt.setString(3, resp.hits.get(this.current_hit).type);
                pstmt.setString(4, resp.hits.get(this.current_hit).tags);
                pstmt.setString(5, resp.hits.get(this.current_hit).previewURL);
                pstmt.setInt(6, resp.hits.get(this.current_hit).previewWidth);
                pstmt.setInt(7, resp.hits.get(this.current_hit).previewHeight);
                pstmt.setString(8, resp.hits.get(this.current_hit).webformatURL);
                pstmt.setInt(9, resp.hits.get(this.current_hit).webformatWidth);
                pstmt.setInt(10, resp.hits.get(this.current_hit).webformatHeight);
                pstmt.setString(11, resp.hits.get(this.current_hit).largeImageURL);
                pstmt.setInt(12, resp.hits.get(this.current_hit).imageWidth);
                pstmt.setInt(13, resp.hits.get(this.current_hit).imageHeight);
                pstmt.setInt(14, resp.hits.get(this.current_hit).imageSize);
                pstmt.setInt(15, resp.hits.get(this.current_hit).views);
                pstmt.setInt(16, resp.hits.get(this.current_hit).downloads);
                pstmt.setInt(17, resp.hits.get(this.current_hit).collections);
                pstmt.setInt(18, resp.hits.get(this.current_hit).likes);
                pstmt.setInt(19, resp.hits.get(this.current_hit).comments);
                pstmt.setInt(20, resp.hits.get(this.current_hit).user_id);
                pstmt.setString(21, resp.hits.get(this.current_hit).user);
                pstmt.setString(22, resp.hits.get(this.current_hit).userImageURL);

                pstmt.executeUpdate();
            } catch (SQLException e) {
                System.out.println(e.getMessage());
                return false;
            }

            return true;
        }
        return false;
    }

    public Hit get_favs() throws SQLException {
        String url = "jdbc:sqlite:identifier.sqlite"; //
        String sql = "SELECT * FROM hits";
        Connection connection = DriverManager.getConnection(url);

        try (Statement stmt = connection.createStatement();
             ResultSet rs = stmt.executeQuery(sql)) {
            while (rs.next()) {
                Hit hit = new Hit();
                hit.id = rs.getInt("id");
                hit.pageURL = (rs.getString("pageURL"));
                hit.type = (rs.getString("type"));
                hit.tags = (rs.getString("tags"));
                hit.previewURL = (rs.getString("previewURL"));
                hit.previewWidth = (rs.getInt("previewWidth"));
                hit.previewHeight = (rs.getInt("previewHeight"));
                hit.webformatURL = (rs.getString("webformatURL"));
                hit.webformatWidth = (rs.getInt("webformatWidth"));
                hit.webformatHeight = (rs.getInt("webformatHeight"));
                hit.largeImageURL = (rs.getString("largeImageURL"));
                hit.imageWidth = (rs.getInt("imageWidth"));
                hit.imageHeight = (rs.getInt("imageHeight"));
                hit.imageSize = (rs.getInt("imageSize"));
                hit.views = (rs.getInt("views"));
                hit.downloads = (rs.getInt("downloads"));
                hit.collections = (rs.getInt("collections"));
                hit.likes = (rs.getInt("likes"));
                hit.comments = (rs.getInt("comments"));
                hit.user_id = (rs.getInt("user_id"));
                hit.user = (rs.getString("user"));
                hit.userImageURL = (rs.getString("userImageURL"));

                favs.add(hit);
            }
        } catch (SQLException e) {
            e.printStackTrace();
        }

        return favs.get(current_favorite);
    }

    public Hit get_fav() throws SQLException {
        if(!favs.isEmpty()){
            return favs.get(current_favorite);
        }else{
            return get_favs();
        }
    }

    public Hit get_next_fav() throws SQLException {
        if(!favs.isEmpty()){
            if(current_favorite < favs.size() - 1){
                current_favorite++;
            }else {
                current_favorite = 0;
            }
            return favs.get(current_favorite);
        }else{
            return get_favs();
        }
    }

    public Hit get_previous_fav() throws SQLException {
        if(!favs.isEmpty()){
            if(current_favorite > 0){
                current_favorite--;
            }else {
                current_favorite = favs.size() - 1;
            }
            return favs.get(current_favorite);
        }else{
            return get_favs();
        }
    }

    public Hit next_image(String query) throws IOException {
        if(this.resp == null || !Objects.equals(query, this.previous_query)) {
            this.resp = API.search(query);
            this.current_hit = 0;
            this.previous_query = query;
        }else{
            if(this.current_hit < this.resp.hits.size() - 1) {
                this.current_hit += 1;
            }else {
                this.current_hit = 0;
            }
        }

        return resp.hits.get(this.current_hit);
    }

    public Hit previous_image(String query) throws IOException {
        if(this.resp == null || !Objects.equals(query, this.previous_query)) {
            this.resp = API.search(query);
            this.current_hit = 0;
            this.previous_query = query;
        }else{
            if(this.current_hit > 0) {
                this.current_hit -= 1;
            }else {
                this.current_hit = this.resp.hits.size() - 1;
            }
        }

        return resp.hits.get(this.current_hit);
    }

    public App(){

    }
}
