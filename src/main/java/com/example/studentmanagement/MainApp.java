package com.example.studentmanagement;

import javafx.application.Application;
import javafx.fxml.FXMLLoader;
import javafx.scene.Scene;
import javafx.stage.Stage;

public class MainApp extends Application {
    @Override
    public void start(Stage stage) throws Exception {
        // Đường dẫn tuyệt đối trong resources
        FXMLLoader loader = new FXMLLoader(getClass().getResource("/view/student-main.fxml"));
        Scene scene = new Scene(loader.load());
        stage.setTitle("Quản lý sinh viên");
        stage.setScene(scene);
        stage.show();
    }

    public static void main(String[] args) {
        launch(args);
    }
}
