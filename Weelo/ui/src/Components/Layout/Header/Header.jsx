import React,{Fragment,useState } from 'react';
import brandLogoImage from 'assets/img/brand/logo.svg';
import {useHistory} from 'react-router-dom';
import {IsAuth,LogOut} from 'Services/authService';
import { Tooltip } from 'reactstrap';

const Header = () => {    
    const [tooltipOpen, setTooltipOpen] = useState(false);

    const toggle = () => setTooltipOpen(!tooltipOpen);
    const history = useHistory();
    
 

    const handleNavigate = (e) => {
        e.preventDefault();
       
        history.push('/Login');
    }
    const handleSession = (e) => {
        e.preventDefault();
        LogOut();
         history.push('/Login');

    }
    
    return (
        <Fragment>
        {
             <section className="menu">
            <div className="container">
               
                <div className="row justify-content-between">
                <div className="col-auto col-img"><a className="logo-reto"  onClick={handleNavigate} href="Login"><img className="img-fluid" src={brandLogoImage} alt="ImageBrand"/></a></div>
                <div className="col-auto"><a className="button button-yellow" href="LogOut" onClick={handleSession}> <span>Cerrar sesión</span></a></div>
                </div>
                
                             
                
                
            </div>
        </section>
        
        }
        </Fragment>
        );
}
 
export default Header;