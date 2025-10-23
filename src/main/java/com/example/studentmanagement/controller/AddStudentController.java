package com.example.studentmanagement.controller;

import javafx.fxml.FXML;
import javafx.scene.control.TextField;
import javafx.stage.Stage;
import com.example.studentmanagement.model.Student;

public class AddStudentController {

    @FXML private TextField txtMaSV;
    @FXML private TextField txtTenSV;
    @FXML private TextField txtTuoi;
    @FXML private TextField txtLop;

    private MainController mainController;

    public void setMainController(MainController mainController) {
        this.mainController = mainController;
    }

    @FXML
    private void addStudent() {
        String maSV = txtMaSV.getText();
        String tenSV = txtTenSV.getText();
        int tuoi = Integer.parseInt(txtTuoi.getText());
        String lop = txtLop.getText();

        mainController.getStudentList().add(new Student(maSV, tenSV, tuoi, lop));
        closeForm();
    }

    @FXML
    private void closeForm() {
        Stage stage = (Stage) txtMaSV.getScene().getWindow();
        stage.close();
    }
}
