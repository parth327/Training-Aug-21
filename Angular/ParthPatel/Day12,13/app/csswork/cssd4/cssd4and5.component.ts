import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-cssd4and5',
  template: `
    <div class="container">
<div class="row">
    <div class="column">
        <img src="../../assets/flex1.webp" style="width:100%">
        <img src="../../assets/flex2.png" style="width:100%">
        <img src="../../assets/flex3.webp" style="width:100%">
    </div>

    <div class="column">
        <img src="../../assets/flex4.jpeg" style="width:100%">
        <img src="../../assets/flex5.png" style="width:100%">
        <img src="../../assets/flex6.png" style="width:100%">
    </div>

    <div class="column">
        <img src="../../assets/flex7.png" style="width:100%">
        <img src="../../assets/flex8.webp" style="width:100%">
        <img src="../../assets/flex9.png" style="width:100%">
    </div>
</div>
</div>
  `,
  styles: [`
  * {
  box-sizing: border-box;
}

body {
  margin: 0;
  font-family: Arial;
}

.header {
  text-align: center;
  padding: 31px;
}

.row {
  display: flex;
  flex-wrap: wrap;
  padding: 0 4px;
}

.column {
  flex: 25%;
  max-width: 33%;
  padding: 0 4px;
}

  .column img {
      margin-top: 10px;
      vertical-align: middle;
  }

@media (max-width: 800px) {
  .column {
      flex: 50%;
      max-width: 50%;
  }
}

@media (max-width: 600px) {
  .column {
      flex: 100%;
      max-width: 100%;
  }
}

  `
  ]
})
export class Cssd4and5Component implements OnInit {

  constructor() { }

  ngOnInit(): void {
  }

}
