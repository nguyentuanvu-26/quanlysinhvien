package com.example.studentmanagement.controller;

import com.example.studentmanagement.model.Student;
import javafx.collections.FXCollections;
import javafx.collections.ObservableList;
import javafx.fxml.FXML;
import javafx.fxml.FXMLLoader;
import javafx.scene.Parent;
import javafx.scene.Scene;
import javafx.scene.control.TableColumn;
import javafx.scene.control.TableView;
import javafx.scene.control.cell.PropertyValueFactory;
import javafx.stage.Modality;
import javafx.stage.Stage;

import java.io.IOException;

public class MainController {

    @FXML private TableView<Student> tableStudent;
    @FXML private TableColumn<Student, String> colMaSV;
    @FXML private TableColumn<Student, String> colTenSV;
    @FXML private TableColumn<Student, Integer> colTuoi;
    @FXML private TableColumn<Student, String> colLop;

    // Danh sách dùng chung (Observable để TableView tự cập nhật)
    private final ObservableList<Student> studentList = FXCollections.observableArrayList();

    @FXML
    public void initialize() {
        // Liên kết cột với thuộc tính trong Student
        colMaSV.setCellValueFactory(new PropertyValueFactory<>("maSV"));
        colTenSV.setCellValueFactory(new PropertyValueFactory<>("tenSV"));
        colTuoi.setCellValueFactory(new PropertyValueFactory<>("tuoi"));
        colLop.setCellValueFactory(new PropertyValueFactory<>("lop"));

        // Dữ liệu mẫu (nếu muốn)
        if (studentList.isEmpty()) {
            studentList.addAll(
                    new Student("SV01", "Nguyễn Văn A", 20, "TH29.14"),
                    new Student("SV02", "Trần Thị B", 21, "TH29.14")
            );
        }

        // Gắn dữ liệu cho TableView
        tableStudent.setItems(studentList);
    }

    // Getter để controller con (Add/Edit/Delete) có thể truy cập
    public ObservableList<Student> getStudentList() {
        return studentList;
    }

    // -------- MỞ FORM THÊM ----------
    @FXML
    private void openAddForm() {
        try {
            FXMLLoader loader = new FXMLLoader(getClass().getResource("/view/student-add.fxml"));
            Parent root = loader.load();

            // truyền MainController vào AddStudentController để nó thêm trực tiếp vào studentList
            AddStudentController controller = loader.getController();
            controller.setMainController(this);

            Stage stage = new Stage();
            stage.setTitle("Thêm sinh viên");
            stage.initModality(Modality.APPLICATION_MODAL);
            stage.setScene(new Scene(root));
            stage.showAndWait(); // đợi đóng cửa sổ

            // TableView dùng ObservableList nên thêm trực tiếp đã hiển thị, có thể refresh nếu cần
            tableStudent.refresh();
        } catch (IOException e) {
            e.printStackTrace();
        }
    }

    // -------- MỞ FORM SỬA ----------
    @FXML
    private void openEditForm() {
        Student selected = tableStudent.getSelectionModel().getSelectedItem();
        if (selected == null) {
            // không chọn gì -> không làm gì (bạn có thể thay bằng alert)
            return;
        }

        try {
            FXMLLoader loader = new FXMLLoader(getClass().getResource("/view/student-edit.fxml"));
            Parent root = loader.load();

            EditStudentController controller = loader.getController();
            controller.setMainController(this);
            controller.setStudent(selected); // truyền đối tượng để sửa

            Stage stage = new Stage();
            stage.setTitle("Sửa sinh viên");
            stage.initModality(Modality.APPLICATION_MODAL);
            stage.setScene(new Scene(root));
            stage.showAndWait();

            tableStudent.refresh();
        } catch (IOException e) {
            e.printStackTrace();
        }
    }

    // -------- MỞ FORM XÓA ----------
    @FXML
    private void openDeleteForm() {
        Student selected = tableStudent.getSelectionModel().getSelectedItem();
        if (selected == null) {
            return;
        }

        try {
            FXMLLoader loader = new FXMLLoader(getClass().getResource("/view/student-delete.fxml"));
            Parent root = loader.load();

            DeleteStudentController controller = loader.getController();
            controller.setMainController(this);
            controller.setStudent(selected);

            Stage stage = new Stage();
            stage.setTitle("Xóa sinh viên");
            stage.initModality(Modality.APPLICATION_MODAL);
            stage.setScene(new Scene(root));
            stage.showAndWait();

            tableStudent.refresh();
        } catch (IOException e) {
            e.printStackTrace();
        }
    }
}
