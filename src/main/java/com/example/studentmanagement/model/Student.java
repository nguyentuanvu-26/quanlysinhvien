package com.example.studentmanagement.model;

public class Student {
    private String maSV;
    private String tenSV;
    private int tuoi;
    private String lop;

    public Student(String maSV, String tenSV, int tuoi, String lop) {
        this.maSV = maSV;
        this.tenSV = tenSV;
        this.tuoi = tuoi;
        this.lop = lop;
    }

    public String getMaSV() { return maSV; }
    public void setMaSV(String maSV) { this.maSV = maSV; }

    public String getTenSV() { return tenSV; }
    public void setTenSV(String tenSV) { this.tenSV = tenSV; }

    public int getTuoi() { return tuoi; }
    public void setTuoi(int tuoi) { this.tuoi = tuoi; }

    public String getLop() { return lop; }
    public void setLop(String lop) { this.lop = lop; }
}
