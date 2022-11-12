import { Fragment } from "react";
import { Dropdown, DropdownButton } from "react-bootstrap";


const toggleOwner = () => {

    return(
        <Fragment>
            <DropdownButton variant="primary" id="dropdwon-basic-button" title="Asign" size="sm">
                <Dropdown.Item>Mark</Dropdown.Item>
                <Dropdown.Item>Israel</Dropdown.Item>
                <Dropdown.Item>Elvira</Dropdown.Item>
            </DropdownButton>
        </Fragment>
    );
}

export default toggleOwner;