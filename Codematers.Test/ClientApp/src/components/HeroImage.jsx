import React from 'react';
import './HeroImage.css'; 
import header_logo from '../assets/images/header_logo.png';

export const HeroImage = () => {    
    return (        
    <div className="hero-image">
        <img className="header-logo" src={header_logo} alt="Header logo" /> 
    </div>)
}