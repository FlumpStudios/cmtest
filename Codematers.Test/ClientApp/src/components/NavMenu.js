import React from 'react';
import { Collapse, Container, Navbar, NavbarBrand, NavbarToggler, NavItem, NavLink } from 'reactstrap';
import { Link } from 'react-router-dom';
import './NavMenu.css';
import nav_logo from '../assets/images/nav_logo.png';

const style = {
  logo: {
    maxHeight: "30px"
  }
}

export default class NavMenu extends React.Component {
  constructor(props) {
    super(props);
    this.toggle = this.toggle.bind(this);
    this.state = {
      isOpen: false
    };
  }
  toggle() {
    this.setState({
      isOpen: !this.state.isOpen
    });
  }
  render() {
    return (
      <header>
        <Navbar className="navbar-expand-sm navbar-toggleable-sm border-bottom box-shadow mb-3 navbar" >

          <NavbarBrand tag={Link} to="/">
            <img style={style.logo} src={nav_logo} alt="F1" />
          </NavbarBrand>
          <NavbarToggler onClick={this.toggle} className="mr-2" />
          <Collapse className="d-sm-inline-flex flex-sm-row-reverse" isOpen={this.state.isOpen} navbar>
            <ul className="navbar-nav flex-grow">
              <NavItem>
                <NavLink tag={Link} className="nav-item" to="/">Home</NavLink>
              </NavItem>
              <NavItem>
                <NavLink tag={Link} className="nav-item" to="/counter">Features</NavLink>
              </NavItem>
              <NavItem>
                <NavLink tag={Link} className="nav-item" to="/fetch-data">News</NavLink>
              </NavItem>
              <NavItem>
                <NavLink tag={Link} className="nav-item" to="/buy-now">Buy Now</NavLink>
              </NavItem>
            </ul>
          </Collapse>
        </Navbar>
      </header>
    );
  }
}
