import { Component } from '@angular/core';
import { Chart } from 'chart.js/auto'

@Component({
  selector: 'app-chart',
  templateUrl: './chart.component.html',
  styleUrls: ['./chart.component.css'],
})
export class ChartComponent {
  public chart: any;
  public chartName = 'Default Name';

  public country1 = 'Country1';
  public country2 = 'Country2';

  public dataType = 'Data type'
  public data1 = 65;
  public data2 = 35;

  createChart() {
    this.chart = new Chart('MyChart', {
      type: 'doughnut',
      data: {
        labels: [
          this.country1,
          this.country2
        ],
        datasets: [{
            label: this.dataType,
            data: [this.data1, this.data2],
            backgroundColor: [
              '#17A2B8',
              '#DC0070',
            ],
            hoverOffset: 4
          },
        ],
      },
      options: {
        aspectRatio: 2.5,
      },
    });
  }

  ngOnInit(): void {
    this.createChart();
  }
}
