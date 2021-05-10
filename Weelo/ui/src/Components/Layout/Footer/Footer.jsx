import React from 'react';
import fbImage from 'assets/img/icons/fb.svg';
import twImage from 'assets/img/icons/tw.svg';
import igImage from 'assets/img/icons/ig.svg';
import legalImage from 'assets/img/brand/legal.svg';
import brandBancolombiaImage from 'assets/img/brand/logo-mastercard-bancolombia.svg';
import pdfFAQ from 'assets/PDF/FAQ.pdf';
import pdfTYC from 'assets/PDF/TYC.pdf';
import {useHistory} from 'react-router-dom';

const Footer = () => {
  const history = useHistory();
  const handleNavigate = (e,push) => {
    e.preventDefault();
    if(push){
      history.push(`/${push}`);
    }

    
  }
    return (  
        <section className="footer">
        <div className="container">
          <div className="row justify-content-center justify-content-md-between align-items-center">
            <div className="col-md-8 d-flex justify-content-center">
              <ul>
                <li><a href="Inicio" onClick={(e)=>handleNavigate(e,'Blog')}>Inicio</a></li>
                <li><a href="Login" onClick={(e)=>handleNavigate(e,'Login')}>¿Tienes un código?</a></li>
                <li><a href={pdfTYC} target="__blank">Términos y condiciones</a></li>
                <li><a href={pdfFAQ}  target="__blank">Preguntas frecuentes</a></li>
                
              </ul>
            </div>
            <div className="col-md-4">
              <ul className="redes">
                <li><a href="Fb" onClick={(e)=>handleNavigate(e)}><img src={fbImage} alt="IconImage"/></a></li>
                <li><a href="Tw" onClick={(e)=>handleNavigate(e)}> <img src={twImage} alt="IconImage"/></a></li>
                <li><a href="Ig" onClick={(e)=>handleNavigate(e)}> <img src={igImage} alt="IconImage"/></a></li>
              </ul>
            </div>
          </div>
        </div>
        <div className="separator">
          <div className="container">
            <div className="row justify-content-between">
              <div className="col-12 col-md-auto">
                <img className="img-fluid" src={brandBancolombiaImage} alt="brand"/></div>
              <div className="col-12 col-md-auto text-right py-4 py-md-0 text-center">
                <img className="img-fluid" src={legalImage} alt="legalImage"/></div>
            </div>
          </div>
        </div>
      </section>
    );
}
 
export default Footer;
