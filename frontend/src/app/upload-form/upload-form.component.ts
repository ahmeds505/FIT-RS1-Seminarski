import { Component, OnInit } from '@angular/core';
import {FileUpload} from "../models/file-upload.model";
import {FileUploadService} from "../services/file-upload.service";

@Component({
  selector: 'app-upload-form',
  templateUrl: './upload-form.component.html',
  styleUrls: ['./upload-form.component.css']
})
export class UploadFormComponent implements OnInit {

  selectedFiles: FileList;
  currentFileUpload: FileUpload;
  percentage: number;


  constructor(private uploadService: FileUploadService) { }

  ngOnInit(): void {
  }

  selectFile(event): void {
    this.selectedFiles   = event.target.files;
  }

  upload(): void {
    const file = this.selectedFiles.item(0);

    //this.selectedFiles = undefined;

    this.currentFileUpload = new FileUpload(file);

     this.uploadService.pushFilesToStorage(this.currentFileUpload).subscribe(percentage => {
       this.percentage = Math.round(percentage);
     }, error => {console.log(error)});
  }
}
