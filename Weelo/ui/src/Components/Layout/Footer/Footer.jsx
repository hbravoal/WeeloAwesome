import React from 'react';
import fbImage from 'assets/img/icons/fb.svg';
import twImage from 'assets/img/icons/tw.svg';
import igImage from 'assets/img/icons/ig.svg';
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
              
                <li><a href="Inicio" onClick={(e)=>handleNavigate(e,'Login')}>Inicio</a></li>
              </ul>
            </div>
            <div className="col-md-4">
              <ul className="redes">
                <li><a href="Fb" href="https://www.facebook.com/HBravoAl/" target="__blank"><img src={fbImage} alt="IconImage"/></a></li>
                
              </ul>
            </div>
          </div>
        </div>      
      </section>
    );
}
 
export default Footer;
