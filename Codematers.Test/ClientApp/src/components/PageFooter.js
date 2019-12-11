import React from 'react';
import logo_codemasters from '../assets/images/logo_codemasters.png';
import logo_pegi from '../assets/images/logo_pegi.png';
import './PageFooter.css';



export const PageFooter = () => {
    return <footer>
        <img className="company-logo" src={logo_codemasters} alt="codemasters" />
        <img className="pegi-logo"  src={logo_pegi} alt="pegi" />
        <div className="footer-text"> © 2019 CODEMASTERS. LICENSED BY FORMULA ONE WORLD WORLD CHAMPIONSHIP LTD AND ITS AFFILIATE </div>
    </footer>  
}