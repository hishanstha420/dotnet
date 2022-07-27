import { Component, OnInit } from '@angular/core';

import { FormControl, FormGroup, ReactiveFormsModule, Validators } from '@angular/forms';

@Component({

selector: 'app-student',

templateUrl: './student.component.html',

})

export class StudentComponent implements OnInit {

ngOnInit(): void {

this.formSubmit();

}

studentForm = new FormGroup({

firstname: new FormControl("")

});

formSubmit() {

console.log(this.studentForm);

}

}