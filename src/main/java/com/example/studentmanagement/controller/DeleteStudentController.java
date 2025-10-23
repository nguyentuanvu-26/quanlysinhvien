package com.example.studentmanagement.controller;

import javafx.fxml.FXML;
import javafx.scene.control.Label;
import javafx.stage.Stage;
import com.example.studentmanagement.model.Student;

public class DeleteStudentController {

    @FXML private Label lblConfirm;

    private MainController mainController;
    private Student student;

    public void setMainController(MainController mainController) {
        this.mainController = mainController;
    }

    public void setStudent(Student student) {
        this.student = student;
        lblConfirm.setText("Xóa sinh viên " + student.getTenSV() + " ?");
    }

    @FXML
    private void deleteStudent() {
        mainController.getStudentList().remove(student);
        closeForm();
    }

    @FXML
    private void closeForm() {
        Stage stage = (Stage) lblConfirm.getScene().getWindow();
        stage.close();
    }
}
