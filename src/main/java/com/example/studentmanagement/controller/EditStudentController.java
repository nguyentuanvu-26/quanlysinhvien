package com.example.studentmanagement.controller;

import javafx.fxml.FXML;
import javafx.scene.control.TextField;
import javafx.stage.Stage;
import com.example.studentmanagement.model.Student;

public class EditStudentController {

    @FXML private TextField txtMaSV;
    @FXML private TextField txtTenSV;
    @FXML private TextField txtTuoi;
    @FXML private TextField txtLop;

    private MainController mainController;
    private Student student;

    public void setMainController(MainController mainController) {
        this.mainController = mainController;
    }

    public void setStudent(Student student) {
        this.student = student;
        txtMaSV.setText(student.getMaSV());
        txtTenSV.setText(student.getTenSV());
        txtTuoi.setText(String.valueOf(student.getTuoi()));
        txtLop.setText(student.getLop());
    }

    @FXML
    private void updateStudent() {
        student.setMaSV(txtMaSV.getText());
        student.setTenSV(txtTenSV.getText());
        student.setTuoi(Integer.parseInt(txtTuoi.getText()));
        student.setLop(txtLop.getText());
        closeForm();
    }

    @FXML
    private void closeForm() {
        Stage stage = (Stage) txtMaSV.getScene().getWindow();
        stage.close();
    }
}
