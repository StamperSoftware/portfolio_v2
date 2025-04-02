import { Component } from '@angular/core';
import { faGithub, faLinkedin } from "@fortawesome/free-brands-svg-icons";
import { FaIconComponent } from "@fortawesome/angular-fontawesome";

@Component({
  selector: 'app-footer',
  standalone: true,
  imports: [
    FaIconComponent
  ],
  templateUrl: './footer.component.html',
  styleUrl: './footer.component.scss'
})
export class FooterComponent {

  protected readonly faLinkedin = faLinkedin;
  protected readonly faGithub = faGithub;
}
