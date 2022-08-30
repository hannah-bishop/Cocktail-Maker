import "./WelcomePage.scss";
import { Link } from "react-router-dom";

export const WelcomePage: React.FunctionComponent = () => {
  return (
    <div className="header">
      <Link to="/home">
        <img src="clicktoenter.JPG" className="logo"></img>
      </Link>
    </div>
  );
};
