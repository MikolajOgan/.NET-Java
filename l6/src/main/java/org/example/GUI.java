package org.example;

import javax.swing.*;
import java.awt.*;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.io.IOException;
import java.net.URL;
import java.sql.SQLException;


public class GUI extends JFrame {
    App app = new App();
    private JTextField textField;
    private JPanel imagePanel;
    private JPanel imagePanelFav;
    private ImageIcon imageIcon;
    private ImageIcon imageIconFav;

    public GUI() throws IOException {
        createView();

        setTitle("Dragon image API");
        setDefaultCloseOperation(EXIT_ON_CLOSE);
        setSize(500, 450);
        setLocationRelativeTo(null);
        setResizable(true);
    }

    private void createView() {
        JPanel panel = new JPanel();
        getContentPane().add(panel);

        textField = new JTextField(20);
        panel.add(textField);

        JButton button1 = new JButton("Search");
        button1.addActionListener(new ButtonClickListener());
        panel.add(button1);

        JButton button2 = new JButton("Next");
        button2.addActionListener(new ButtonClickListener());
        panel.add(button2);

        JButton button3 = new JButton("Previous");
        button3.addActionListener(new ButtonClickListener());
        panel.add(button3);

        JButton button4 = new JButton("Add favourite");
        button4.addActionListener(new ButtonClickListener());
        panel.add(button4);

        JButton openNewWindowButton = new JButton("Favourites");
        openNewWindowButton.addActionListener(new ActionListener() {
            public void actionPerformed(ActionEvent e) {
                // Create and display the new window
                JFrame newFrame = new JFrame("Fav viewer");
                newFrame.setDefaultCloseOperation(JFrame.DISPOSE_ON_CLOSE);
                newFrame.setSize(500, 400);
                newFrame.setLocationRelativeTo(null);
                newFrame.setVisible(true);

                JPanel panel_fav = new JPanel();
                newFrame.getContentPane().add(panel_fav); // Add to new frame's content pane

                JButton next_fav_button = new JButton("Next");
                next_fav_button.addActionListener(_ -> {
                    try {
                        URL newUrl = new URL(app.get_next_fav().largeImageURL); // New image URL
                        imageIconFav = new ImageIcon(newUrl);
                    } catch (IOException | SQLException ex) {
                        ex.printStackTrace();
                        imageIconFav = new ImageIcon(); // Default empty image
                    }
                    imagePanelFav.repaint();
                });

                panel_fav.add(next_fav_button);

                JButton previous_fav_button = new JButton("Previous");
                previous_fav_button.addActionListener(_ -> {
                    try {
                        URL newUrl = new URL(app.get_previous_fav().largeImageURL); // New image URL
                        imageIconFav = new ImageIcon(newUrl);
                    } catch (IOException | SQLException ex) {
                        ex.printStackTrace();
                        imageIconFav = new ImageIcon(); // Default empty image
                    }
                    imagePanelFav.repaint();
                });

                panel_fav.add(previous_fav_button);

                try {
                    URL initialUrl = new URL(app.get_fav().largeImageURL); // Initial image URL
                    imageIconFav = new ImageIcon(initialUrl);
                } catch (IOException er) {
                    er.printStackTrace();
                    imageIconFav = new ImageIcon(); // Default empty image
                } catch (SQLException ex) {
                    ex.printStackTrace();
                    imageIconFav = new ImageIcon();
                }

                imagePanelFav = new JPanel() {
                    @Override
                    protected void paintComponent(Graphics g) {
                        super.paintComponent(g);
                        if (imageIconFav != null) {
                            g.drawImage(imageIconFav.getImage(), 0, 0, getWidth(), getHeight(), this);
                        }
                    }
                };
                imagePanelFav.setPreferredSize(new Dimension(300, 300));
                panel_fav.add(imagePanelFav);

            }
        });
        panel.add(openNewWindowButton);

        try {
            URL initialUrl = new URL(app.get_image("").largeImageURL); // Initial image URL
            imageIcon = new ImageIcon(initialUrl);
        } catch (IOException e) {
            e.printStackTrace();
            imageIcon = new ImageIcon(); // Default empty image
        }

        imagePanel = new JPanel() {
            @Override
            protected void paintComponent(Graphics g) {
                super.paintComponent(g);
                if (imageIcon != null) {
                    g.drawImage(imageIcon.getImage(), 0, 0, getWidth(), getHeight(), this);
                }
            }
        };
        imagePanel.setPreferredSize(new Dimension(300, 300));
        panel.add(imagePanel);
    }

    private class ButtonClickListener implements ActionListener {
        @Override
        public void actionPerformed(ActionEvent e) {
            String command = e.getActionCommand();
            // Handle button click events here
            if (command.equals("Search")) {
                try {
                    URL newUrl = new URL(app.get_image(textField.getText()).largeImageURL); // New image URL
                    imageIcon = new ImageIcon(newUrl);
                } catch (IOException ex) {
                    ex.printStackTrace();
                    imageIcon = new ImageIcon(); // Default empty image
                }
                imagePanel.repaint();
            } else if (command.equals("Next")) {
                try {
                    URL newUrl = new URL(app.next_image(textField.getText()).largeImageURL); // New image URL
                    imageIcon = new ImageIcon(newUrl);
                } catch (IOException ex) {
                    ex.printStackTrace();
                    imageIcon = new ImageIcon(); // Default empty image
                }
                imagePanel.repaint();
            } else if (command.equals("Previous")) {
                try {
                    URL newUrl = new URL(app.previous_image(textField.getText()).largeImageURL); // New image URL
                    imageIcon = new ImageIcon(newUrl);
                } catch (IOException ex) {
                    ex.printStackTrace();
                    imageIcon = new ImageIcon(); // Default empty image
                }
                imagePanel.repaint();
            } else if (command.equals("Add favourite")) {
                app.fave_add();
            }
        }
    }

    public static void main(String[] args) {
        SwingUtilities.invokeLater(() -> {

            try {
                new GUI().setVisible(true);
            } catch (IOException e) {
                throw new RuntimeException(e);
            }
        });
    }
}
